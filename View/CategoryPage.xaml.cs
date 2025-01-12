using MauiApp2.Views;

namespace MauiApp2;

public partial class CategoryPage : ContentPage
{
    private readonly Game _game;

    public CategoryPage()
    {
        InitializeComponent();
        _game = new Game();
    }

    private async void OnNextClicked(object sender, EventArgs e)
    {
        // Controleer of er een categorie is geselecteerd
        if (CategoryPicker.SelectedItem == null)
        {
            await DisplayAlert("Error", "Please select a category.", "OK");
            return;
        }

        string selectedCategory = CategoryPicker.SelectedItem.ToString();

        // Haal 5 vragen op op basis van de categorie
        var questions = _game.GetQuestionsByCategory(selectedCategory, 5);

        // Navigeer naar QuestionPage en geef de vragen door
        await Navigation.PushAsync(new QuestionPage(questions));
    }
}