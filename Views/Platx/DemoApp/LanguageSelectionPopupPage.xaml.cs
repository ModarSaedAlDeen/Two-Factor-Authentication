namespace MauiKit.Views;

public partial class LanguageSelectionPopupPage : PopupPage
{
    public LanguageSelectionPopupPage()
    {
		InitializeComponent();
        BindingContext = new LanguageSelectionPopupViewModel();
    }
}