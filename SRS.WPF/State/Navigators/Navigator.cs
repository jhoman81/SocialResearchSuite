﻿using SRS.WPF.Commands;
using SRS.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SRS.WPF.State.Navigators
{
    public class Navigator : INavigator, INotifyPropertyChanged
    {        
        public ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get 
            {  
                return _currentViewModel; 
            }
            set 
            {  
                _currentViewModel = value; 
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);

        public event PropertyChangedEventHandler? PropertyChanged;
        
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
