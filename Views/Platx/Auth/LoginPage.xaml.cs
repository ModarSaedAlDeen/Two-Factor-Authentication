namespace MauiKit.Views.Forms;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void LoginButtonClicked(object sender, EventArgs e)
    {
        if (Application.Current.MainPage is NavigationPage navPage)
        {
            await navPage.PushAsync(new PasswordVerificationPage());
        }
        else
        {
            Application.Current.MainPage = new NavigationPage(new PasswordVerificationPage());
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new ForgotPasswordPage());
        if (Application.Current.MainPage is NavigationPage navPage)
        {
            await navPage.PushAsync(new ForgotPasswordPage());
        }
        else
        {
            Application.Current.MainPage = new NavigationPage(new ForgotPasswordPage());
        }

    }

}