namespace MauiApp2.Views;

public partial class QuestionPage : ContentPage
{
    public QuestionPage()
    {
    }

    public QuestionPage(List<Models.Question> questions)
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}