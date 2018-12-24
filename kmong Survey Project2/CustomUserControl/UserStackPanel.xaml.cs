using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kmong_Survey_Project2.CustomStackPanel
{
    /// <summary>
    /// UserStackPanel.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UserStackPanel : UserControl
    {
        public UserStackPanel()
        {
            InitializeComponent();
        }

        public int RadioButtonNumber
        {
            get { return (int)GetValue(RadioButtonNumberProperty); }
            set { SetValue(RadioButtonNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RadioButtonNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty 
            RadioButtonNumberProperty = DependencyProperty.Register(
                "RadioButtonNumber", 
                typeof(int), 
                typeof(UserStackPanel), 
                new PropertyMetadata(0, OnRadioButtonNumberChanged));

        public string RadioButtonTargetBindingName
        {
            get { return (string)GetValue(RadioButtonTargetBindingNameProperty); }
            set { SetValue(RadioButtonTargetBindingNameProperty, value); }
        }
        // Using a DependencyProperty as the backing store for RadioButtonTargetBindingName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RadioButtonTargetBindingNameProperty =
            DependencyProperty.Register("RadioButtonTargetBindingName", 
                typeof(string), 
                typeof(UserStackPanel), 
                new PropertyMetadata(null, OnRadioButtonTargetBindingNameChanged));


        public string RadioButtonContentSet
        {
            get { return (string)GetValue(RadioButtonContentSetProperty); }
            set { SetValue(RadioButtonContentSetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RadioButtonContentSet.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RadioButtonContentSetProperty =
            DependencyProperty.Register("RadioButtonContentSet", 
                typeof(string), 
                typeof(UserStackPanel), 
                new PropertyMetadata(null, OnRadioButtonContentSetChanged));

        private static void OnRadioButtonNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserStackPanel my = (UserStackPanel)d;
            ChangeOnDP(my, (int)e.NewValue, my.RadioButtonTargetBindingName, my.RadioButtonContentSet);
        }

        private static void OnRadioButtonTargetBindingNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserStackPanel my = (UserStackPanel)d;
            ChangeOnDP(my, my.RadioButtonNumber, (string)e.NewValue, my.RadioButtonContentSet);
        }

        private static void OnRadioButtonContentSetChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserStackPanel my = (UserStackPanel)d;
            ChangeOnDP(my, my.RadioButtonNumber, my.RadioButtonTargetBindingName, (string)e.NewValue);
        }

        private static void ChangeOnDP(UserStackPanel d, int num, string target, string contents)
        {
            string tmp = contents;
            if (tmp == null) return;
            string[] ButtonContents = tmp.Split(',');

            string bindingTarget = target;

            var tt = LogicalTreeHelper.GetChildren(d);
            var stackpanel = tt.Cast<FrameworkElement>().ElementAt(0) as StackPanel;
            if (stackpanel.Children != null) stackpanel.Children.Clear();
            if (bindingTarget == null) return;

            for (int i = 1; i <= num; i++)
            {
                string ttmp = "";
                if (i-1 < ButtonContents.Length) ttmp= ButtonContents[i - 1];
                ((StackPanel)stackpanel).Children.Add(new CustomRadioButton(bindingTarget, ButtonContents[i-1], i));
            }
        }
    }
}
