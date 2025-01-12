namespace MauiApp2;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Simpelweg navigeren naar de HomePage
        await Navigation.PushAsync(new HomePage());
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Navigeren naar de RegisterPage
        await Navigation.PushAsync(new RegisterPage());
    }
}