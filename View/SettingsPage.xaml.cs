namespace MauiApp2;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    private void OnDarkModeToggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            // Schakel naar Dark Mode
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            // Schakel terug naar Light Mode
            Application.Current.UserAppTheme = AppTheme.Light;
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}