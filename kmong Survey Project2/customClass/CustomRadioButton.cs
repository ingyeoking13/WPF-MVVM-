using kmong_Survey_Project2.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace kmong_Survey_Project2
{
    public class CustomRadioButton : RadioButton
    {
        public CustomRadioButton(string TargetName, string content, int convVal)
        {
            Binding bind= new Binding(TargetName);
            bind.Mode = BindingMode.TwoWay;
            bind.Converter = new RadioButtonConverters();
            bind.ConverterParameter = convVal;
            SetBinding(IsCheckedProperty, bind);
            Content = content;
        }
    }
}
