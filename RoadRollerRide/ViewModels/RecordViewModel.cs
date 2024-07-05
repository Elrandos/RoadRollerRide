using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;
using RoadRollerRide.Models;
using RoadRollerRide.Services;
using RoadRollerRide.Persistence;
using System.Collections.ObjectModel;
using RoadRollerRide.Models.Dto;
using System.Diagnostics;
using System.Linq;

namespace RoadRollerRide.ViewModels
{
    public class RecordViewModel : ViewModelBase
    {
        private MainWindowViewModel _mainWindowViewModel;
        private RecordService _recordService;
        public ObservableCollection<RecordsDto> Records { get; set; }

        public ReactiveCommand<Unit, Task> BackCommand { get; }

        public RecordViewModel(MainWindowViewModel mainWindowViewModel, IAppDbContext appDbContext)
        {
            _mainWindowViewModel = mainWindowViewModel;
            _recordService = new RecordService(appDbContext);
            BackCommand = ReactiveCommand.Create(Back);
            LoadRecords();

            Debug.WriteLine($"Loaded {Records.Count} records.");
        }

        private void LoadRecords()
        {
            var records = _recordService.GetAll();
            var sortedRecords = records.OrderBy(r => r.Time).ToList();

            Records = new ObservableCollection<RecordsDto>();

            for (int i = 0; i < sortedRecords.Count; i++)
            {
                var record = sortedRecords[i];
                Records.Add(new RecordsDto
                {
                    Number = (i + 1).ToString(),
                    MapName = record.Map.Name, // Assuming Map has a Name property
                    CarName = record.Car.Brand, // Assuming Car has a Name property
                    PlayerName = record.PlayerName,
                    Time = record.Time.ToString(@"hh\:mm\:ss\:fff")
                });
            }
        }
        private Task ShowRecords()
        {
            _mainWindowViewModel.ShowRecords();
            return Task.CompletedTask;
        }

        private Task Back()
        {
            _mainWindowViewModel.ShowDirtRally();
            return Task.CompletedTask;
        }
    }
}