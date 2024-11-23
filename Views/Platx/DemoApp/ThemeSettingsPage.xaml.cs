namespace MauiKit.Views;
public partial class ThemeSettingsPage : BasePage
{
    public ThemeSettingsPage()
    {
        InitializeComponent();
        BindingContext = new ThemeSettingsViewModel();
    }

    async void OnCloseSetting_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
