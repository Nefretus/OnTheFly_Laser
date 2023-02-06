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

namespace Engine {
    public class TableSettingsTypeConverter : TypeConverter {
        public static IDictionary<String, Int32> ConvertEnumToDictionary<K>() {
            return Enum.GetValues(typeof(K)).Cast<Int32>().ToDictionary(currentItem => Enum.GetName(typeof(K), currentItem));
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {
            return sourceType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
            if (value is string) {
                TableConfiguration settings = new TableConfiguration();
                string[] data = ((string)value).Split(new char[] { ',' });
                settings.TableType = (TableType)ConvertEnumToDictionary<TableType>()[data.ElementAt(0)];
                settings.MaxForwardLimitX = Convert.ToInt32(data.ElementAt(1));
                settings.MaxForwardLimitY = Convert.ToInt32(data.ElementAt(2));
                settings.Actuator = (ActuatorType)ConvertEnumToDictionary<ActuatorType>()[data.ElementAt(3)];
                string test = data.ElementAt(4);
                settings.Controller = (ControllerType)ConvertEnumToDictionary<ControllerType>()[data.ElementAt(4)];
                return settings;
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) {
            if(destinationType == typeof(string)) {
                TableConfiguration settings = value as TableConfiguration;
                return string.Format("{0},{1},{2},{3},{4}", 
                    Enum.GetName(typeof(TableType), 
                    settings.TableType), 
                    settings.MaxForwardLimitX, 
                    settings.MaxForwardLimitY,
                    settings.Actuator,
                    settings.Controller);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
