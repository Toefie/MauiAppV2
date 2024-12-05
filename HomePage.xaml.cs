namespace MauiApp2;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        // Navigeren terug naar de vorige pagina
        await Navigation.PopAsync();
    }
}