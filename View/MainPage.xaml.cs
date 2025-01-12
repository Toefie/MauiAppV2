using MauiApp2.Views;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnStartGameClicked(object sender, EventArgs e)
    {
        // Navigeer naar GamePage
        await Navigation.PushAsync(new GamePage());
    }

    private async void OnManageQuestionsClicked(object sender, EventArgs e)
    {
        // Navigeer naar QuestionPage
        await Navigation.PushAsync(new QuestionPage());
    }
}