using kmong_Survey_Project2.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmong_Survey_Project2.ViewModel
{
    public class 대근육ViewModel : Observable
    {
        private ObservableCollection<int> _대근육;

        public ObservableCollection<int> 대근육 
        {
            get { return _대근육; }
            set { SetProperty(ref _대근육, value); }
        }

        public 대근육ViewModel()
        {
            _대근육 = new ObservableCollection<int>(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        }
    }
}
