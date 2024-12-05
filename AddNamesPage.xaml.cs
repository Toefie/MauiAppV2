namespace MauiApp2;

public partial class AddNamesPage : ContentPage
{
    public AddNamesPage()
    {
        InitializeComponent();
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        // Hier kun je invoervelden verwerken
        await DisplayAlert("Success", "Names added successfully!", "OK");
        await Navigation.PopAsync();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}