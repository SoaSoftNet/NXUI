BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>().UsePlatformDetect();

class App : Application {
    public override void OnFrameworkInitializationCompleted() {
        Styles.Add(new FluentTheme(new Uri("avares://MinimalAvalonia")));
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            desktop.MainWindow = new Window {
                Title = "MinimalAvalonia",
                Content = new TextBlock { Text = "MinimalAvalonia" }
            };
        }
        base.OnFrameworkInitializationCompleted();
    }
}
