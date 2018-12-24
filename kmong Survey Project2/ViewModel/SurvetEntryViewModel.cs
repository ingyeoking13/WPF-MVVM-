using kmong_Survey_Project2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmong_Survey_Project2.ViewModel
{
    public class SurvetEntryViewModel : Observable
    {
        private int _동행자= 1;
        public int 동행자
        {
            get { return _동행자; }
            set { SetProperty(ref _동행자, value); }
        }

        private int _발달상문제=1;
        public int 발달상문제
        {
            get { return _발달상문제; }
            set { SetProperty(ref _발달상문제, value); }
        }
    }
}
