using ReactiveUI;
using System.Reactive;
using RoadRollerRide.Interfaces.Services;
using RoadRollerRide.Models;

namespace RoadRollerRide.ViewModels
{
    public class DirtRallyViewModel : ViewModelBase
    {
        private string _result;
        private readonly IRandomService _randomService;
        private readonly IDatabaseService _databaseService;

        public DirtRallyViewModel(IRandomService randomService, IDatabaseService databaseService)
        {
            _randomService = randomService;
            _databaseService = databaseService;

            RandomCarCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                Database database = _databaseService.LoadDatabase();
                var cars = _databaseService.GetAllCarsForDirtRally(database);
                var choosenCar = await _randomService.GetRandomCarAsync(cars);

                Result = $"Marka: {choosenCar.Brand}, Model: {choosenCar.Model}";
            });

            RandomMapCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                Database database = _databaseService.LoadDatabase();
                var maps = _databaseService.GetAllMapsForDirtRally(database);
                var choosenMap = await _randomService.GetRandomMapAsync(maps);

                Result = $"Marka: {choosenMap.Location}, Model: {choosenMap.Name}";
            });

            RandomBothCommand = ReactiveCommand.Create(() =>
            {
                Result = "Wylosowano mapę i samochód";
            });

            ShowRecordsCommand = ReactiveCommand.Create(() =>
            {
                //kod przejścia do rekordów
            });
        }

        public string Result
        {
            get => _result;
            set => this.RaiseAndSetIfChanged(ref _result, value);
        }

        public ReactiveCommand<Unit, Unit> RandomMapCommand { get; }
        public ReactiveCommand<Unit, Unit> RandomCarCommand { get; }
        public ReactiveCommand<Unit, Unit> RandomBothCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowRecordsCommand { get; }
    }
}