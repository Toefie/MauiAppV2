namespace MauiApp2;

public partial class QuestionPage : ContentPage
{
    public QuestionPage(List<Question> questions)
    {
        InitializeComponent();

        // Koppel de vragenlijst aan de CollectionView
        QuestionsList.ItemsSource = questions;
    }

    private async void OnScoreboardClicked(object sender, EventArgs e)
    {
        // Navigeer naar de ScoreboardPage
        await Navigation.PushAsync(new ScoreboardPage());
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}