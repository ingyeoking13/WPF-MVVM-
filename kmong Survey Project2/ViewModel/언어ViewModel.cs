﻿using kmong_Survey_Project2.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmong_Survey_Project2.ViewModel
{
    public class 언어ViewModel : Observable
    {
        public ObservableCollection<int> 언어 { get; set; } = 
            new ObservableCollection<int>(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 });
    }
}
