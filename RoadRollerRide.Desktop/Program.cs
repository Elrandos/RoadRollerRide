using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.ReactiveUI;
using RoadRollerRide.Models.Cars;
using RoadRollerRide.Models;
using RoadRollerRide.Models.Maps;
using RoadRollerRide.Services;

namespace RoadRollerRide.Desktop;

class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        DatabaseService databaseService = new DatabaseService();
        Database database = databaseService.LoadDatabase();

        List<Car> dirtRallyCars = databaseService.GetAllCarsForDirtRally(database);
        List<Map> dirRallyMaps = databaseService.GetAllMapsForDirtRally(database);

        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
    }

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI();
}
