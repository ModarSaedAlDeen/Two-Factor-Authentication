using RGPopup.Maui.Services; // «· √ﬂœ „‰ ≈÷«›… «·„ﬂ »…

namespace MauiKit.Views.Forms;

public partial class ForgotPasswordPage : BasePage
{
	public ForgotPasswordPage()
	{
		InitializeComponent();
	}

    private async void ResetPassword_Clicked(object sender, EventArgs e)
    {
        await PopupNavigation.Instance.PushAsync(new ActionSuccessPopup());
        //Application.Current.MainPage.DisplayAlert("Button Clicked!", "Please add your function.", "OK");
    }
}