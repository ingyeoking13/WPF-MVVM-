using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace kmong_Survey_Project2.Converters
{
    public class RadioButtonConverters : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value == (int)parameter) return true;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            /*
            if((bool)value == true) return parameter;
            return Binding.DoNothing;
            */
            return (bool)value?parameter:Binding.DoNothing;
        }
    }
}
