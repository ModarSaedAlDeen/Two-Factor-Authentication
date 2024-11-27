using MauiKit.Views.Platx.HomePage;
using System.Diagnostics;
using MauiKit.Resources.Translations;

namespace MauiKit.Controls.Commons;
public partial class UpdatePage : ContentPage
{
    public UpdatePage(bool isMandatory)
    {
        InitializeComponent();
        SetupPage(isMandatory);
    }

    private void SetupPage(bool isMandatory)
    {
        if (isMandatory)
        {
            // ��� ������� ���������
            UpdateMessage.IsVisible = true;
            OptionalUpdateMessage.IsVisible = false;
            ContinueButton.IsVisible = false;
            ForceUpdateMessage.IsVisible = true;
        }
        else
        {
            // ��� ������� ����������
            UpdateMessage.IsVisible = false;
            OptionalUpdateMessage.IsVisible = true;
            ContinueButton.IsVisible = true;
            ForceUpdateMessage.IsVisible = false;
        }
    }

    private void OnUpdateClicked(object sender, EventArgs e)
    {
        // ��� ���� �������
        Browser.Default.OpenAsync("https://www.facebook.com");
    }

    private void OnContinueClicked(object sender, EventArgs e)
    {
        // �������� ��� ������ ��������
        //Application.Current.MainPage = new NavigationPage(new ForgotPasswordPage());
        Application.Current.MainPage = new NavigationPage(new StartPage());
    }

    private void OnExitAppClicked(object sender, EventArgs e)
    {
        // ����� �������
        Process.GetCurrentProcess().Kill();
    }
}