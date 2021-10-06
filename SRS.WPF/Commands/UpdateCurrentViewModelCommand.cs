using SRS.WPF.State.Navigators;
using SRS.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SRS.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter is ViewType) 
            { 
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Participants:
                        _navigator.CurrentViewModel = new ParticipantsViewModel();
                        break;
                    case ViewType.Events:
                        _navigator.CurrentViewModel = new EventsViewModel();
                        break;
                    case ViewType.Notes:
                        _navigator.CurrentViewModel = new NotesViewModel();
                        break;
                    case ViewType.Places:
                        _navigator.CurrentViewModel = new PlacesViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
