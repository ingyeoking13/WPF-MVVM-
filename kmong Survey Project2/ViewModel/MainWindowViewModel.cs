using kmong_Survey_Project2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace kmong_Survey_Project2.ViewModel
{
    class MainWindowViewModel : Observable
    {
        private List<Observable> _viewModelList = new List<Observable>();
        private int idx = 0;

        public RelayCommand goNextCommand { get; private set; }
        public RelayCommand goBackCommand { get; private set; }

        private Observable _CurrentViewModel;
        public MainWindowViewModel()
        {
            goBackCommand = new RelayCommand(goBack, canGoDown);
            goNextCommand = new RelayCommand(goNext, canGoUp);

            _viewModelList.Add(new SurvetEntryViewModel());
            _viewModelList.Add(new 대근육ViewModel());
            _viewModelList.Add(new 소근육ViewModel());
            _viewModelList.Add(new 인지ViewModel());
            _viewModelList.Add(new 사회성ViewModel());
            _viewModelList.Add(new 언어ViewModel());
        }

        public Observable CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set
            {
                SetProperty(ref _CurrentViewModel, value);
                goBackCommand.OnCanExecuteChanged();
                goNextCommand.OnCanExecuteChanged();
            }
        }

        private void goBack()
        {
            idx--;
            CurrentViewModel = _viewModelList[idx];
        }
        private void goNext()
        {
            idx++;
            CurrentViewModel = _viewModelList[idx];
        }
        private bool canGoUp()
        {
            if (0 <= idx+1 && idx+1 < _viewModelList.Count) return true;
            return false;
        }
        private bool canGoDown()
        {
            if (0 <= idx - 1 && idx - 1 < _viewModelList.Count) return true;
            return false;
        }
    }
}
