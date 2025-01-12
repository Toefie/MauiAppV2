namespace MauiApp2;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Zet de SplashScreen en navigeer daarna naar MainPage
        MainPage = new NavigationPage(new MainPage());
    }
}