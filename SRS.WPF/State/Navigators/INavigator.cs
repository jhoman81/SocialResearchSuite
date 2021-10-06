using SRS.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SRS.WPF.State.Navigators
{
    public enum ViewType
    {
        Home,
        Participants,
        Events,
        Notes,
        Places
    }
    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
