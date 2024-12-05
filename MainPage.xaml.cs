using Microsoft.Maui.Controls;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        // Hardcoded credentials
        private const string CorrectUsername = "admin";
        private const string CorrectPassword = "1234";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (username == CorrectUsername && password == CorrectPassword)
            {
                // Redirect naar de TabbedPage
                Application.Current.MainPage = new MainTabbedPage();
            }
            else
            {
                // Toon foutmelding
                MessageLabel.Text = "Onjuiste gebruikersnaam of wachtwoord.";
                MessageLabel.IsVisible = true;
            }
        }
    }
}
