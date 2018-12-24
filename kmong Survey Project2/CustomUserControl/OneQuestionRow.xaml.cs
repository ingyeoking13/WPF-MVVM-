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

namespace kmong_Survey_Project2.CustomUserControl
{
    /// <summary>
    /// OneQuestionRow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OneQuestionRow : UserControl
    {
        public int RadioButtonNum
        {
            get { return (int)GetValue(RadioButtonNumProperty); }
            set { SetValue(RadioButtonNumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RadioButtonNum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RadioButtonNumProperty =
            DependencyProperty.Register("RadioButtonNum", typeof(int), typeof(OneQuestionRow), new PropertyMetadata(0));

        public string RadioButtonContentSets
        {
            get { return (string)GetValue(RadioButtonContentSetsProperty); }
            set { SetValue(RadioButtonContentSetsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RadioButtonContentSets.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RadioButtonContentSetsProperty =
            DependencyProperty.Register("RadioButtonContentSets", typeof(string), typeof(OneQuestionRow), new PropertyMetadata(null));

        public string RadioButtonTargetBindingName
        {
            get { return (string)GetValue(RadioButtonTargetBindingNameProperty); }
            set { SetValue(RadioButtonTargetBindingNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RadioButtonTargetBindingName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RadioButtonTargetBindingNameProperty =
            DependencyProperty.Register("RadioButtonTargetBindingName", typeof(string), typeof(OneQuestionRow), new PropertyMetadata(null));

        public string ContentValue
        {
            get { return (string)GetValue(ContentValueProperty); }
            set { SetValue(ContentValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ContentValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentValueProperty =
            DependencyProperty.Register("ContentValue", typeof(string), typeof(OneQuestionRow), new PropertyMetadata(null));

        public int ContentNumber
        {
            get { return (int)GetValue(ContentNumberProperty); }
            set { SetValue(ContentNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ContentNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentNumberProperty =
            DependencyProperty.Register("ContentNumber", typeof(int), typeof(OneQuestionRow), new PropertyMetadata(133));

        public OneQuestionRow()
        {
            InitializeComponent();
        }
    }
}
