namespace MauiApp2;

public partial class AddQuestionPage : ContentPage
{
    public AddQuestionPage()
    {
        InitializeComponent();
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        // Controleer of een vraag en categorie zijn ingevuld
        if (string.IsNullOrWhiteSpace(QuestionEntry.Text))
        {
            await DisplayAlert("Error", "Please enter a question.", "OK");
            return;
        }

        if (CategoryPicker.SelectedItem == null)
        {
            await DisplayAlert("Error", "Please select a category.", "OK");
            return;
        }

        // Verkrijg de ingevoerde vraag, categorie en moeilijkheidsgraad
        string question = QuestionEntry.Text;
        string category = CategoryPicker.SelectedItem.ToString();
        int difficulty = (int)DifficultySlider.Value;

        // Simuleer het opslaan van de vraag
        await DisplayAlert("Success", $"Question added:\n\nQuestion: {question}\nCategory: {category}\nDifficulty: {difficulty} stars", "OK");

        // Wis velden na opslaan
        QuestionEntry.Text = string.Empty;
        CategoryPicker.SelectedItem = null;
        DifficultySlider.Value = 3;

        // Keer terug naar de vorige pagina
        await Navigation.PopAsync();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}