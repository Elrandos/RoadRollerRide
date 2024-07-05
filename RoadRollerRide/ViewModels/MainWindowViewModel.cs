using ReactiveUI;
using RoadRollerRide.Model.Dto;
using RoadRollerRide.Persistence;

namespace RoadRollerRide.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object _currentView;
        private IAppDbContext _appDbContext;
        private UserDto _currentUser;
        public string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RandomCarChooser;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public object CurrentView
        {
            get => _currentView;
            set => this.RaiseAndSetIfChanged(ref _currentView, value);
        }

        public UserDto CurrentUser
        {
            get => _currentUser;
            set => this.RaiseAndSetIfChanged(ref _currentUser, value);
        }

        public MainWindowViewModel()
        {
            _appDbContext = new AppDbContext(ConnectionString);
            CurrentView = new LoginViewModel(this, _appDbContext);
        }

        public void ShowDirtRally()
        {
            CurrentView = new DirtRallyViewModel(this, _appDbContext);
        }

        public void ShowGameChooser()
        {
            CurrentView = new GameChooserViewModel(this, _appDbContext);
        }
        public void ShowRecords()
        {
            CurrentView = new GameChooserViewModel(this, _appDbContext);
        }
        //public void AddBooks()
        //{
        //    CurrentView = new CreateBookViewModel(this, _appDbContext);
        //}
        //public void DeleteBooks()
        //{
        //    CurrentView = new DeleteBookViewModel(this, _appDbContext);
        //}
        public void ShowRegisterView()
        {
            CurrentView = new RegisterViewModel(this, _appDbContext);
        }

        public void ShowLoginView()
        {
            CurrentView = new LoginViewModel(this, _appDbContext);
        }
    }
}
