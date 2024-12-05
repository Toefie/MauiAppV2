namespace MauiApp2;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Instellen van de NavigationPage met LoginPage als root
        MainPage = new NavigationPage(new LoginPage());
    }
}