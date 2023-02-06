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
    public enum ChannelType {
        xAxis = 1,
        yAxis = 2,
        zAxis = 3,
        NONE = 4
    }

    public enum TABLE_DIRECTION { // NONE means we are not moving at all
        NONE = 0,
        Forward,
        Backward
    }

    public abstract class MotorController {
        protected bool simulatorMode;
        protected string serialNumber;
        private List<Tuple<ChannelType, ulong>> taskList = new List<Tuple<ChannelType, ulong>>();

        //For client implementation
        public abstract IGenericAdvancedMotor channelX { get; }
        public abstract IGenericAdvancedMotor channelY { get; }

        public abstract DeviceInfo deviceInfo { get; }
        public abstract void Disconnect();
        public abstract void Connect();
        // End region

        public static void PrintPosErrorMessage(decimal pos) => MessageBox.Show($"This move would result moving the motor out of its operational range\nMotor max posistion is: {pos} mm");
        public bool IsMoving(IGenericAdvancedMotor channel) { return channel.Status.IsMoving; }
        public bool IsHoming(IGenericAdvancedMotor channel) { return channel.Status.IsHoming; }
        public bool IsHomed(IGenericAdvancedMotor channel) { return channel.Status.IsHomed; }
        public bool ReachedForwardLimit(IGenericAdvancedMotor channel, ChannelType type) { return channel.DevicePosition >= GetMaxPositionForChannel(type); }
        public decimal GetMaxPositionForChannel(ChannelType type) {
            switch (type) {
                case ChannelType.xAxis:
                    return Settings.Default.TableInfo.MaxForwardLimitX;
                case ChannelType.yAxis:
                    return Settings.Default.TableInfo.MaxForwardLimitY;
                default:
                    MessageBox.Show("This channel is not implemented");
                    return decimal.Zero;
            }
        }
        public bool ReachedReverseLimit(IGenericAdvancedMotor channel) { return channel.DevicePosition <= channel.AdvancedMotorLimits.LengthMinimum; }
        public bool AllTasksFinished() { return taskList.Count == 0; }
      
        private void TaskCompleted(ulong _taskID) {
            for (int i = 0; i < taskList.Count; i++) {
                if ((taskList[i].Item2 > 0) && (taskList[i].Item2 == _taskID))
                    taskList.RemoveAt(i);
            }
        }

        private void StopButtonEvent(ulong _taskID) {
            ChannelType typeToBeRemoved = ChannelType.NONE;
            int index = taskList.FindIndex(task => { return (task.Item2 > 0) && task.Item2 == _taskID; });
            typeToBeRemoved = taskList[index].Item1;
            taskList.RemoveAt(index);
            for (int i = 0; i < taskList.Count; i++) {
                if (taskList[i].Item1 == typeToBeRemoved)
                    taskList.RemoveAt(i);
            }
        }

        public void Home(IGenericAdvancedMotor channel, ChannelType channelType) {
            ulong taskID = channel.Home(TaskCompleted);
            taskList.Add(new Tuple<ChannelType, ulong>(channelType, taskID));
        }

        public void MoveAbsolute(IGenericAdvancedMotor channel, ChannelType channelType, decimal position) {
            decimal maxPos = GetMaxPositionForChannel(channelType);
            if (position > maxPos)
                throw new MoveToInvalidPositionException(serialNumber, "Move Absolute", position);
            channel.SetMoveAbsolutePosition(position);
            ulong taskID = channel.MoveAbsolute(TaskCompleted);
            taskList.Add(new Tuple<ChannelType, ulong>(channelType, taskID));
        }

        public void MoveRelative(IGenericAdvancedMotor channel, ChannelType channelType, decimal relativeDistance, MotorDirection direction = MotorDirection.Forward) {
            decimal maxPos = GetMaxPositionForChannel(channelType);
            switch (direction) {
                case MotorDirection.Forward: {
                        decimal newPos = relativeDistance + channel.DevicePosition;
                        if (newPos > maxPos)
                            throw new MoveToInvalidPositionException(serialNumber, "Move Absolute", newPos, "Requested position exceeds table maximum range");
                        break;
                    }
                case MotorDirection.Backward: {
                        decimal newPos = channel.DevicePosition - relativeDistance;
                        if (newPos < channel.AdvancedMotorLimits.LengthMinimum)
                            throw new MoveToInvalidPositionException(serialNumber, "Move Absolute", newPos, "Requested position exceeds table minimum range");
                        break;
                    }
            }
            channel.SetMoveRelativeDistance(relativeDistance);
            ulong taskID = channel.MoveRelative(direction, channel.GetMoveRelativeDistance(), TaskCompleted);
            taskList.Add(new Tuple<ChannelType, ulong>(channelType, taskID));
        }

        public void Stop(IGenericAdvancedMotor channel, ChannelType channelType) {
            ulong taskID = channel.Stop(StopButtonEvent);
            taskList.Add(new Tuple<ChannelType, ulong>(channelType, taskID));
        }
    }
}
