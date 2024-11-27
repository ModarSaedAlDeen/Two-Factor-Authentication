//namespace MauiKit.Views.Platx.HomePage;

//public partial class PlatxHomePage : BasePage
//{
//	public PlatxHomePage()
//	{
//		InitializeComponent();
//	}
//}

using System.Timers;
using Timer = System.Timers.Timer;


namespace MauiKit.Views.Platx.HomePage;

public partial class PlatxHomePage : BasePage
{
    private Timer _timer; 

    public PlatxHomePage()
    {
        InitializeComponent();
        StartConfirmationTimer();

        //StartCountdown();
    }

    //private void StartCountdown()
    //{
    //    _countdownValue = 30;
    //    CountdownLabel.Text = _countdownValue.ToString();
    //    ResendStack.IsVisible = false;

    //    _timer = new Timer(1000); // 
    //    _timer.Elapsed += OnCountdownElapsed;
    //    _timer.Start();
    //}

    //private void OnCountdownElapsed(object sender, ElapsedEventArgs e)
    //{
    //    _countdownValue--;

    //    MainThread.BeginInvokeOnMainThread(() =>
    //    {
    //        if (_countdownValue > 0)
    //        {
    //            CountdownLabel.Text = _countdownValue.ToString();
    //        }
    //        else
    //        {
    //            _timer.Stop();
    //            CountdownLabel.Text = "0";
    //            ResendStack.IsVisible = true;
    //        }
    //    });
    //}

    //private void OnResendClicked(object sender, EventArgs e)
    //{
    //    StartCountdown();
    //}

    //protected override void OnDisappearing()
    //{
    //    base.OnDisappearing();
    //    _timer?.Stop();
    //}
    private void StartConfirmationTimer()
    {
        // ����� ������ ������� �� 5 �����
        _timer = new Timer(5000); // 5000ms = 5 �����
        _timer.Elapsed += async (sender, e) => await ShowConfirmationPopup();
        _timer.AutoReset = true; // ��������� ������
        _timer.Start();
    }

    private async Task ShowConfirmationPopup()
    {
        // ��� ������� ��������
        var popup = new ActionConfirmationPopup();
        popup.ConfirmationAccepted += OnConfirmationAccepted;
        popup.ConfirmationRejected += OnConfirmationRejected;

        await MainThread.InvokeOnMainThreadAsync(async () =>
        {
            await PopupNavigation.Instance.PushAsync(popup);
        });
    }

    private void OnConfirmationAccepted(object sender, EventArgs e)
    {
        // ����� ���� ��� ������
        MainThread.BeginInvokeOnMainThread(() =>
        {
            this.FindByName<Label>("MainLabel").Text = "Confirmed";
        });
        _timer.Stop(); // ����� ������
    }

    private void OnConfirmationRejected(object sender, EventArgs e)
    {
        // ����� �������� ��� 5 �����
        // (�� ���� ������ ����� ��� ��� ������ ������ �����)
    }
    private async void OnSettingsToolbarItemIsClicked(object sender, EventArgs e)
    {
        //await PopupNavigation.Instance.PushAsync(new ThemeSettingsPopupPage());
        await Navigation.PushModalAsync(new ThemeSettingsPage());
    }
}
