using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using MillzysMod.Installer.ViewModels;
using MillzysMod.Installer.Views;

namespace MillzysMod.Installer
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new StartWindow
                {
                    DataContext = new StartWindowViewModel(),
                    Width = 700d,
                    Height = 400d,
                    CanResize = false,
                    WindowStartupLocation = Avalonia.Controls.WindowStartupLocation.CenterScreen
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
