using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thorlabs.MotionControl.GenericMotorCLI.AdvancedMotor;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericMotorCLI;
using Flight.Properties;

namespace Engine {
    public partial class StageControl : UserControl {
        private MotorController controller;
        private Timer timer;
        private IGenericAdvancedMotor channel;
        private ChannelType channelType;

        public StageControl() {
            InitializeComponent();
        }

        public static bool CheckInputCorrectness(string input, bool absoluteMoveInput = false) {
            try {
                decimal distance = decimal.Parse(input);
                if (!absoluteMoveInput) {
                    if (distance < 0)
                        throw new FormatException();
                }
            }
            catch (FormatException) {
                MessageBox.Show("Entered invalid value");
                input = string.Empty;
                return false;
            }
            return true;
        }

        public void Initialize(ChannelType _channelType, MotorController _controller) {
            timer = new Timer { Interval = 1 };
            timer.Tick += UpdateData;
            channelType = _channelType;
            controller = _controller;
            switch (channelType) {
                case ChannelType.xAxis:
                    channel = controller.channelX;
                    ActuatorLb.Text = "Actuator " + Settings.Default.TableInfo.Actuator.ToString() + "X";
                    break;
                case ChannelType.yAxis:
                    channel = controller.channelY;
                    ActuatorLb.Text = "Actuator " + Settings.Default.TableInfo.Actuator.ToString() + "Y";
                    break;
                default:
                    break;
            }
            velocityLb.Text = $"Velocity: {channel.GetVelocityParams().MaxVelocity} mm/s";
            accLb.Text = $"Acc: {channel.GetVelocityParams().Acceleration} mm/s^2";
            PosLb.Text = channel.DevicePosition.ToString();
            TravelLb.Text = $"Travel: {controller.GetMaxPositionForChannel(channelType)}mm";
            UpdateHomingStatus();
        }

        private void UpdateData(object sender, EventArgs e) {
            PosLb.Text = channel.DevicePosition.ToString();
            if (controller.AllTasksFinished()) {
                UpdateHomingStatus();
                if (!controller.IsMoving(channel) && !controller.IsHoming(channel))
                    this.StatusLb.Text = "Idle";
                timer.Enabled = false;
            }
        }

        private void UpdateHomingStatus() {
            if (controller.IsHomed(channel)) {
                HomeText.Text = "Homed";
                this.homedLight.BackColor = Color.Lime;
            }
            else {
                this.homedLight.BackColor = Color.Red;
                HomeText.Text = "Not Homed";
            }
            if (controller.ReachedForwardLimit(channel, channelType))
                ForwardLimit.BackColor = Color.Red;
            else
                ForwardLimit.BackColor = Color.Gray;
            if (controller.ReachedReverseLimit(channel))
                ReverseLimit.BackColor = Color.Red;
            else
                ReverseLimit.BackColor = Color.Gray;
        }

        private void panel3_Paint(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle,
                                             Color.Red, 3, ButtonBorderStyle.Solid,
                                             Color.Red, 3, ButtonBorderStyle.Solid,
                                             Color.Red, 3, ButtonBorderStyle.Solid,
                                             Color.Red, 3, ButtonBorderStyle.Solid);
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle,
                                             Color.Red, 3, ButtonBorderStyle.Solid,
                                             Color.Red, 3, ButtonBorderStyle.Solid,
                                             Color.Red, 3, ButtonBorderStyle.Solid,
                                             Color.Red, 3, ButtonBorderStyle.Solid);
        }

        private void RelativeBtForward_Click(object sender, EventArgs e) {
            if (StatusLb.Text.Equals("Moving") || controller.IsHoming(channel)) return;
            if (!CheckInputCorrectness(this.RelativeValue.Text)) return;
            try {
                controller.MoveRelative(channel, channelType, decimal.Parse(this.RelativeValue.Text));
            }
            catch (MoveToInvalidPositionException) {
                MotorController.PrintPosErrorMessage(controller.GetMaxPositionForChannel(channelType));
                return;
            }
            this.StatusLb.Text = "Moving";
            timer.Enabled = true;
        }

        private void RelativeBtBack_Click(object sender, EventArgs e) {
            if (StatusLb.Text.Equals("Moving") || controller.IsHoming(channel)) return; // controller.isMoving doesnt work as intented
            if (!CheckInputCorrectness(this.RelativeValue.Text)) return;
            try {
                controller.MoveRelative(channel, channelType, decimal.Parse(RelativeValue.Text), MotorDirection.Backward);
            }
            catch (MoveToInvalidPositionException) {
                MotorController.PrintPosErrorMessage(channel.AdvancedMotorLimits.LengthMinimum);
                return;
            }
            this.StatusLb.Text = "Moving";
            timer.Enabled = true;
        }

        private void AbsoluteBt_Click(object sender, EventArgs e) {
            if (StatusLb.Text.Equals("Moving") || controller.IsHoming(channel)) return;
            if (!CheckInputCorrectness(this.AbsoluteValue.Text, true)) return;
            try {
                controller.MoveAbsolute(channel, channelType, decimal.Parse(AbsoluteValue.Text));
            }
            catch (MoveToInvalidPositionException) {
                MotorController.PrintPosErrorMessage(controller.GetMaxPositionForChannel(channelType));
                return;
            }
            this.StatusLb.Text = "Moving";
            timer.Enabled = true;
        }

        private void StopBt_Click(object sender, EventArgs e) {
            if (StatusLb.Text.Equals("Moving") || controller.IsHoming(channel)) {
                controller.Stop(channel, channelType);
            }
            this.StatusLb.Text = "Idle";
        }

        private void HomeBt_Click(object sender, EventArgs e) {
            if (StatusLb.Text.Equals("Homing") || StatusLb.Text.Equals("Moving")) return;
            controller.Home(channel, channelType);
            StatusLb.Text = "Homing";
            timer.Enabled = true;
        }

        private void SettingsBt_Click(object sender, EventArgs e) {
            using (Options dlg = new Options(channel)){
                if(dlg.ShowDialog() == DialogResult.OK) {
                    dlg.ApplySettings();
                    this.accLb.Text = "Acc: " + channel.GetVelocityParams().Acceleration.ToString() + " mm/s^2";
                    this.velocityLb.Text = "Velocity: " + channel.GetVelocityParams().MaxVelocity.ToString() + " mm/s";
                }
            }
        }
    }
}