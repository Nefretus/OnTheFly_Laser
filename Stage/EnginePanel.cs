using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericMotorCLI;
using Flight;

namespace Engine {
    public partial class EnginePanel : Form {
        Flight.Flight caller;
        public EnginePanel(Flight.Flight callingFrom) {
            InitializeComponent();
            caller = callingFrom;
            stageControl2.Initialize(ChannelType.xAxis, caller.controller);
            stageControl1.Initialize(ChannelType.yAxis, caller.controller);
        }

        private void EngineForm_Load(object sender, EventArgs e) => caller.engineFormClosed = false;

        private void EngineForm_FormClosed(object sender, FormClosedEventArgs e) => caller.engineFormClosed = true;
        
    }
}
