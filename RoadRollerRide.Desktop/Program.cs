using System;
using Avalonia;
using Avalonia.ReactiveUI;

namespace RoadRollerRide.Desktop;

static class Program
{
    [STAThread]
    public static void Main(string[] args) =>BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI();
}
