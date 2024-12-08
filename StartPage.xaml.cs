namespace MauiApp2;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }

    private async void OnStartGameClicked(object sender, EventArgs e)
    {
        // Navigate to Add Names Page
        await Navigation.PushAsync(new AddNamesPage());
    }


    private async void OnAddNamesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddNamesPage());
    }

    private async void OnAddQuestionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddQuestionPage());
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}