namespace MauiApp2;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnStartGameClicked(object sender, EventArgs e)
    {
        // Navigate to Add Names Page or Start Game Page
        await Navigation.PushAsync(new StartPage());
    }

    private async void OnAddQuestionClicked(object sender, EventArgs e)
    {
        // Navigate to Add Question Page
        await Navigation.PushAsync(new AddQuestionPage());
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        // Navigate to Settings Page
        await Navigation.PushAsync(new SettingsPage());
    }

    private async void OnScoreboardClicked(object sender, EventArgs e)
    {
        // Navigate to Scoreboard Page
        await Navigation.PushAsync(new ScoreboardPage());
    }
}