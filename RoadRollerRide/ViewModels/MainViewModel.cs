using ReactiveUI;
using System.Reactive;

namespace RoadRollerRide.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Witaj w RoadRollerRide!";
    public ReactiveCommand<Unit, Unit> NextCommand { get; }

    public MainViewModel()
    {
        NextCommand = ReactiveCommand.Create(Next);
    }

    private void Next()
    {
        // Do something when the button is clicked
    }
}