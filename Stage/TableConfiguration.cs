using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
using Flight.Properties;

namespace Engine {
    public enum TableType {
        BentchtopStepperMotor = 0,
        CustomTable
    }

    public enum ActuatorType {
        MAX201 = 0,
        CustomActuator
    }

    public enum ControllerType {
        BSC103 = 0,
        CustomController
    }
   
    [TypeConverter(typeof(TableSettingsTypeConverter))]
    [SettingsSerializeAs(SettingsSerializeAs.String)]
    public partial class TableConfiguration : Form {
        public TableType TableType { get; set; }
        public int MaxForwardLimitX { get; set; }
        public int MaxForwardLimitY { get; set; }
        public ActuatorType Actuator { get; set; }
        public ControllerType Controller { get; set; }

        public TableConfiguration() {
            InitializeComponent();
            textBox1.DataBindings.Add(new Binding("Text", this, "MaxForwardLimitX"));
            textBox2.DataBindings.Add(new Binding("Text", this, "MaxForwardLimitY"));
            comboBox1.Items.AddRange(Enum.GetNames(new TableType().GetType()));
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(Enum.GetNames(new ActuatorType().GetType()));
            comboBox2.SelectedIndex = 0;
            comboBox3.Items.AddRange(Enum.GetNames(new ControllerType().GetType()));
            comboBox3.SelectedIndex = 0;
        }

        private void TutorialBt_Click(object sender, EventArgs e) {
            MessageBox.Show("Rozumiem ze chcesz dodac customowy stolik, a wiec:\n" +
              "1. Stworz wlasna klase innicjalizujaca stolik\n" +
              "2. Wybierz z listy customowy stolik i aktuator\n" +
              "3. Przejdz do instrukcji switch - klasa Flight, linijka 1504 i wywolaj konstruktor swojej klasy\n" +
              "Tak wiem, ten system dodawania jest bezsensowny ale bylo za pozno zeby go wywalic");
        }

        private void OkBt_Click(object sender, EventArgs e) {
            TableType = (TableType)Enum.Parse(typeof(TableType), comboBox1.SelectedItem.ToString());
            Actuator = (ActuatorType)Enum.Parse(typeof(ActuatorType), comboBox2.SelectedItem.ToString());
            Controller = (ControllerType)Enum.Parse(typeof(ControllerType), comboBox3.SelectedItem.ToString());
        }
    }
}