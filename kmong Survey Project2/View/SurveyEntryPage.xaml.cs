using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using kmong_Survey_Project2.CustomStackPanel;
using kmong_Survey_Project2.ViewModel;

namespace kmong_Survey_Project2.View
{
    /// <summary>
    /// SurveyEntryPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SurveyEntryPage : Page
    {

        SurvetEntryViewModel viewmodel = new SurvetEntryViewModel();

        public SurveyEntryPage()
        {
            DataContext = viewmodel;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new 대근육());
        }
    }
}
