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

namespace Engine {
    public partial class Options : Form {
        IGenericAdvancedMotor channel;

        public Options(IGenericAdvancedMotor _channel) {
            InitializeComponent();
            channel = _channel;
            VelLb.Text = channel.GetVelocityParams().MaxVelocity.ToString();
            AccLb.Text = channel.GetVelocityParams().Acceleration.ToString();
        }

        public void ApplySettings() {
            decimal velocity, acc;
            if (!StageControl.CheckInputCorrectness(VelLb.Text) || !StageControl.CheckInputCorrectness(AccLb.Text))
                return;
            velocity = decimal.Parse(VelLb.Text);
            acc = decimal.Parse(AccLb.Text);
            if (velocity > channel.AdvancedMotorLimits.VelocityMaximum || acc > channel.AdvancedMotorLimits.AccelerationMaximum) {
                MessageBox.Show("Entered value cannot be set to the motor");
                return;
            }
            channel.SetVelocityParams(velocity, acc);
            VelLb.Text = channel.GetVelocityParams().MaxVelocity.ToString();
            AccLb.Text = channel.GetVelocityParams().Acceleration.ToString();
        }
    }
}
