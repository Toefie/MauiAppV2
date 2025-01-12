namespace MauiApp2;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        // Navigeren terug naar de LoginPage na registratie
        await DisplayAlert("Success", "Your account has been created!", "OK");
        await Navigation.PopAsync();
    }

    private async void OnBackToLoginClicked(object sender, EventArgs e)
    {
        // Navigeren terug naar de LoginPage
        await Navigation.PopAsync();
    }
}