using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;

namespace MillzysMod.Installer.Views
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        public void QuestButtonPressed(object sender, RoutedEventArgs e)
        {
            new QuestInstallWindow
            {
                Width = 1000d,
                Height = 700d,
                CanResize = false,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            }.Show();
            Close();
        }
    }
}
