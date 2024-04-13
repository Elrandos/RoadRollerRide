using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RoadRollerRide.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        var dirtRallyButton = this.FindControl<Button>("DirtRallyButton");
        if (dirtRallyButton != null)
            dirtRallyButton.Click += (sender, args) =>
            {
                var dirtRallyView = new DirtRallyView();
                var mainWindow = (MainWindow)this.VisualRoot;
                mainWindow.Content = dirtRallyView;
            };
    }
}
