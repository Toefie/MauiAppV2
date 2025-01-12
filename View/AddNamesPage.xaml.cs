using MauiApp2.Views;

namespace MauiApp2;

public partial class AddNamesPage : ContentPage
{
    private readonly Game _game;

    public AddNamesPage()
    {
        InitializeComponent();
        _game = new Game(); // Instantie van Game
    }

    private async void OnStartGameClicked(object sender, EventArgs e)
    {
        // Haal 5 willekeurige vragen op
        var questions = _game.GetRandomQuestions(5);

        // Controleer of er vragen zijn opgehaald
        if (questions == null || questions.Count == 0)
        {
            await DisplayAlert("Error", "No questions available.", "OK");
            return;
        }

        // Navigeer naar QuestionPage en geef de vragen door
        await Navigation.PushAsync(new QuestionPage(questions));
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}