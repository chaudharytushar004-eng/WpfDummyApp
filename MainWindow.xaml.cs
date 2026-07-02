using System.Windows;
using System.Windows.Controls;
using WpfDummyApp.Views;

namespace WpfDummyApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // App khulte hi default Home page dikhado
            MainContent.Content = new HomeView();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            if (sender is not Button btn) return;

            switch (btn.Name)
            {
                case "BtnHome":
                    MainContent.Content = new HomeView();
                    break;
                case "BtnSecurity":
                    MainContent.Content = new SecurityView();
                    break;
                case "BtnAccount":
                    MainContent.Content = new AccountView();
                    break;
                case "BtnSettings":
                    MainContent.Content = new SettingsView();
                    break;
            }
        }
    }
}
