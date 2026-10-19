using System.Windows;

namespace tobabalkaos
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Induláskor a főoldal jelenjen meg.
            mainFrame.Navigate(new HomePage());
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HomePage());
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ProfilePage());
        }
        
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SettingsPage());
        }

        private void SelfDestruct_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SelfDestruct());
        }

        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();

            infoWindow.Show();
        }

        private void OpenDialog_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();

            infoWindow.ShowDialog();
        }

        private void OpenSugo_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();

            helpWindow.ShowDialog();
        }
    }
}
