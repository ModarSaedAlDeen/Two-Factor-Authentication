
namespace MauiKit.Views.Onboardings;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private async void TakeTour_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DemoWalkthroughPage());
    }

    private async void Skip_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
        //Application.Current.MainPage = new NavigationPage(new LoginPage());
    }

}