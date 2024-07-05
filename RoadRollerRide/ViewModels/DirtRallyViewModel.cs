using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;
using RoadRollerRide.Models;
using RoadRollerRide.Services;
using RoadRollerRide.Persistence;

namespace RoadRollerRide.ViewModels
{
    public class DirtRallyViewModel : ViewModelBase
    {
        private MainWindowViewModel _mainWindowViewModel;
        private readonly RandomService _randomService;
        public ReactiveCommand<Unit, Unit> RandomCarCommand { get; }
        public ReactiveCommand<Unit, Unit> RandomMapCommand { get; }
        public ReactiveCommand<Unit, Unit> RandomBothCommand { get; }
        public ReactiveCommand<Unit, Task> ShowRecordsCommand { get; }
        public ReactiveCommand<Unit, Task> ChangeGameCommand { get; }

        public DirtRallyViewModel(MainWindowViewModel mainWindowViewModel, IAppDbContext appDbContext)
        {
            _mainWindowViewModel = mainWindowViewModel;
            RandomCarCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                //var cars = _databaseService.GetAllCarsForDirtRally(database);
                //var choosenCar = await _randomService.GetRandomCarAsync(cars);
                var car = await _randomService.GetRandomCarAsync();

            });

            RandomMapCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                //var maps = _databaseService.GetAllMapsForDirtRally(database);
                //var choosenMap = await _randomService.GetRandomMapAsync(maps);

            });

            RandomBothCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                //var maps = _databaseService.GetAllMapsForDirtRally(database);
                //var choosenMap = await _randomService.GetRandomMapAsync(maps);

            });

            ChangeGameCommand = ReactiveCommand.Create(ChangeGame);
            ShowRecordsCommand = ReactiveCommand.Create(ShowRecords);

        }

        private async Task GetRandomCar()
        {
            var car = await _randomService.GetRandomCarAsync();

        }

        private Task ShowRecords()
        {
            _mainWindowViewModel.ShowRecords();
            return Task.CompletedTask;
        }

        private Task ChangeGame()
        {
            _mainWindowViewModel.ShowGameChooser();
            return Task.CompletedTask;
        }
    }
}