using System;
using System.Collections.Generic;
using System.Text;
using Thorlabs.MotionControl.Benchtop.StepperMotorCLI;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericMotorCLI;
using Thorlabs.MotionControl.GenericMotorCLI.Settings;
using Thorlabs.MotionControl.GenericMotorCLI.AdvancedMotor;
using Thorlabs.MotionControl.GenericMotorCLI.ControlParameters;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using Flight.Properties;

namespace Engine {
    public class StepperMotorController: MotorController {
        private BenchtopStepperMotor motor;
        public  ThorlabsBenchtopStepperMotorSettings settingsXAxis { get; }
        public  ThorlabsBenchtopStepperMotorSettings settingsYAxis { get; }
        public override IGenericAdvancedMotor channelX { get { return motor.GetChannel((short)ChannelType.xAxis); } }
        public override IGenericAdvancedMotor channelY { get { return motor.GetChannel((short)ChannelType.yAxis); } }
        public override DeviceInfo deviceInfo { get { return motor.GetDeviceInfo(); } }

        public StepperMotorController(bool _simulatorMode) {
            simulatorMode = _simulatorMode;
            if (simulatorMode)
                SimulationManager.Instance.InitializeSimulations();
            try {
                DeviceManagerCLI.BuildDeviceList();
            }
            catch (Exception) {}
            List<string> serialNumbers = DeviceManagerCLI.GetDeviceList(BenchtopStepperMotor.DevicePrefix70);
            if (serialNumbers.Count == 0) {
                MessageBox.Show("No connected devices");
                throw new Exception();
            }
            if (simulatorMode)
                serialNumber = "70000001"; // default serial number for my simulation
            else
                serialNumber = serialNumbers[0];
            if (!serialNumbers.Contains(serialNumber)) {
                MessageBox.Show("No serial number was found");
                throw new Exception();
            }
            motor = BenchtopStepperMotor.CreateBenchtopStepperMotor(serialNumber);
            if (motor == null) {
                MessageBox.Show("{0} is not a BentchtopStepperMotor", serialNumber);
                throw new Exception();
            }
            motor.Connect(serialNumber);
            if (!motor.IsConnected) {
                switch (motor.USBConnected) {
                    case ThorlabsConnectionManager.ConnectionStates.Connected: {
                            MessageBox.Show("Failed to connect but USB connected OK");
                            break;
                        }
                    case ThorlabsConnectionManager.ConnectionStates.Disconnected: {
                            MessageBox.Show("Failed to connect");
                            break;
                        }
                }
                throw new Exception();
            }
            StepperMotorChannel xAxisChannel = motor.GetChannel((short)ChannelType.xAxis);
            StepperMotorChannel yAxisChannel = motor.GetChannel((short)ChannelType.yAxis);
            if (xAxisChannel == null || yAxisChannel == null) {
                MessageBox.Show("ChannelType failed to connect");
                throw new Exception();
            }
            xAxisChannel.Connect(serialNumber);
            xAxisChannel.WaitForSettingsInitialized(3000);
            if (!xAxisChannel.IsSettingsInitialized()) {
                MessageBox.Show("Settings of the first channel failed to initialize");
                throw new Exception();
            }
            xAxisChannel.LoadMotorConfiguration(xAxisChannel.DeviceID);
            yAxisChannel.Connect(serialNumber);
            yAxisChannel.WaitForSettingsInitialized(3000);
            if (!yAxisChannel.IsSettingsInitialized()) {
                MessageBox.Show("Settings of the second channel failed to initialize");
                throw new Exception();
            }
            yAxisChannel.LoadMotorConfiguration(yAxisChannel.DeviceID);
            xAxisChannel.StartPolling(250);
            Thread.Sleep(500);
            xAxisChannel.EnableDevice();
            Thread.Sleep(500);
            yAxisChannel.StartPolling(250);
            Thread.Sleep(500);
            yAxisChannel.EnableDevice();
            Thread.Sleep(500);
        }
    
        public override void Disconnect() {
            if (motor != null && motor.GetConnectionState() == ThorlabsConnectionManager.ConnectionStates.Connected) {
                StepperMotorChannel xAxisChannel = motor.GetChannel((short)ChannelType.xAxis);
                StepperMotorChannel yAxisChannel = motor.GetChannel((short)ChannelType.yAxis);
                xAxisChannel.StopPolling();
                xAxisChannel.DisableDevice();
                yAxisChannel.StopPolling();
                yAxisChannel.DisableDevice();
                motor.Disconnect(false); 
                if (simulatorMode) SimulationManager.Instance.UninitializeSimulations();
            }
        }

        public override void Connect() {
            if (motor != null && motor.GetConnectionState() == ThorlabsConnectionManager.ConnectionStates.Disconnected) {
                motor.Connect(motor.SerialNo);
                StepperMotorChannel xAxisChannel = motor.GetChannel((short)ChannelType.xAxis);
                StepperMotorChannel yAxisChannel = motor.GetChannel((short)ChannelType.yAxis);
                xAxisChannel.Connect(motor.SerialNo);
                xAxisChannel.StartPolling(250);
                Thread.Sleep(500);
                yAxisChannel.Connect(motor.SerialNo);
                yAxisChannel.StartPolling(250);
                Thread.Sleep(500);
                yAxisChannel.EnableDevice();
            }
        }
    }
}

