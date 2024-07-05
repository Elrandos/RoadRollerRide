using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;
using RoadRollerRide.Persistence;

namespace RoadRollerRide.ViewModels
{
    public class GameChooserViewModel : ViewModelBase
    {
        private MainWindowViewModel _mainWindowViewModel;

        public ReactiveCommand<Unit, Task> DirtRallyCommand { get; }
        public ReactiveCommand<Unit, Task> LogOutCommand { get; }

        public GameChooserViewModel(MainWindowViewModel mainWindowViewModel, IAppDbContext appDbContext)
        {
            _mainWindowViewModel = mainWindowViewModel;

            DirtRallyCommand = ReactiveCommand.Create(DirtRally);

            LogOutCommand = ReactiveCommand.Create(LogOut);
        }

        private Task DirtRally()
        {
            _mainWindowViewModel.ShowDirtRally();
            return Task.CompletedTask;
        }

        private Task LogOut()
        {
            _mainWindowViewModel.ShowLoginView();
            return Task.CompletedTask;
        }
    }
}