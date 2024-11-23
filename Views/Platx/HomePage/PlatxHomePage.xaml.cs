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
    private int _countdownValue = 30;
    private Timer _timer;

    public PlatxHomePage()
    {
        InitializeComponent();
        StartCountdown();
    }

    private void StartCountdown()
    {
        _countdownValue = 30;
        CountdownLabel.Text = _countdownValue.ToString();
        ResendStack.IsVisible = false;

        _timer = new Timer(1000); // ÚÏ ÊäÇÒáí ßá ËÇäíÉ
        _timer.Elapsed += OnCountdownElapsed;
        _timer.Start();
    }

    private void OnCountdownElapsed(object sender, ElapsedEventArgs e)
    {
        _countdownValue--;

        // ÇáÊÍÏíË Úáì æÇÌåÉ ÇáãÓÊÎÏã
        MainThread.BeginInvokeOnMainThread(() =>
        {
            if (_countdownValue > 0)
            {
                CountdownLabel.Text = _countdownValue.ToString();
            }
            else
            {
                _timer.Stop();
                CountdownLabel.Text = "0";
                ResendStack.IsVisible = true;
            }
        });
    }

    private void OnResendClicked(object sender, EventArgs e)
    {
        StartCountdown();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _timer?.Stop();
    }
}
