
namespace MauiKit.Views.Actions;

public partial class ActionSuccessBackgroundPopup : PopupPage
{
    public string Message { get; set; }

    public ActionSuccessBackgroundPopup()
	{
		InitializeComponent();
        BindingContext = this; // ·—»ÿ «·—”«·… „⁄ «·‹ Label

    }

    private async void GoBack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
