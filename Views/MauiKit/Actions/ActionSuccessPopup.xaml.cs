
namespace MauiKit.Views.Actions;

public partial class ActionSuccessPopup : PopupPage
{
	public ActionSuccessPopup()
	{
		InitializeComponent();
	}

    private async void GoBack_Clicked(object sender, EventArgs e)
    {
        // ≈€·«ﬁ «·ﬁ«∆„… «·„‰»Àﬁ…
        await PopupNavigation.Instance.PopAsync();

        // «· ‰ﬁ· ≈·Ï ’›Õ…  ”ÃÌ· «·œŒÊ· ≈–« ·“„ «·√„—
        Application.Current.MainPage = new LoginPage();
    }
}