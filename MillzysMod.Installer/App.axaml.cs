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
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                    Width = 700d,
                    Height = 400d,
                    CanResize = false,              
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
