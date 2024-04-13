using ReactiveUI;
using RoadRollerRide.Views;
using Avalonia;
using System.Reactive;
using System.Windows.Input;

namespace RoadRollerRide.ViewModels;

public class MainViewModel : ViewModelBase
{
    
    public string Greeting => "Witaj w RoadRollerRide!";
    private readonly ReactiveCommand<Unit, Unit> _navigateToNewViewCommand;

    public ICommand NavigateToNewViewCommand => _navigateToNewViewCommand;


    public MainViewModel()
    {
        _navigateToNewViewCommand = ReactiveCommand.Create(NavigateToNewView);
    }

    private void NavigateToNewView()
    {
        var newView = new DirtRallyView();
        var mainWindow = (MainWindow)Application.Current.Resources;
        mainWindow.Content = newView;
    }
}