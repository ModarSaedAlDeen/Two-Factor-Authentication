namespace MauiKit.Views.Actions;

public partial class ActionConfirmationPopup : PopupPage
{
    // √Õœ«À · ÕœÌœ «·≈Ã—«¡ (ﬁ»Ê·/—›÷)
    public event EventHandler ConfirmationAccepted;
    public event EventHandler ConfirmationRejected;

    public ActionConfirmationPopup()
    {
        InitializeComponent();
    }

    private async void AcceptButton_Clicked(object sender, EventArgs e)
    {
        ConfirmationAccepted?.Invoke(this, EventArgs.Empty);
        await PopupNavigation.Instance.PopAsync();
    }

    private async void RejectButton_Clicked(object sender, EventArgs e)
    {
        ConfirmationRejected?.Invoke(this, EventArgs.Empty);
        await PopupNavigation.Instance.PopAsync();
    }
}
