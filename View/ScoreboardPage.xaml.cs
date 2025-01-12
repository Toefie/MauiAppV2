namespace MauiApp2;

public partial class ScoreboardPage : ContentPage
{
    public ScoreboardPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        // Ga terug naar de vorige pagina
        await Navigation.PopAsync();
    }
}