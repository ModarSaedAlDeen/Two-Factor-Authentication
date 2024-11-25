using MauiKit.Views.Platx.HomePage;

namespace MauiKit.Controls.Commons;

public partial class RetryPage : ContentPage
{
    private readonly IConnectivityService _connectivityService;

    public RetryPage()
    {
        InitializeComponent();
        _connectivityService = new ConnectivityService(); // �� �������� DI
        BindingContext = new RetryViewModel(_connectivityService);
    }
}

public class RetryViewModel
{
    private readonly IConnectivityService _connectivityService;
    public Command RetryCommand { get; }

    public RetryViewModel(IConnectivityService connectivityService)
    {
        _connectivityService = connectivityService;

        RetryCommand = new Command(Retry);
    }

    private async void Retry()
    {
        if (_connectivityService.IsInternetAvailable())
        {
            // ��� ��� ������� ��������� ������
            Application.Current.MainPage = new NavigationPage(new PlatxHomePage());
        }
        else
        {
            // ����� ��� ����� �� ����� ����� ���
            await Application.Current.MainPage.DisplayAlert("Error", "There is no connection until now", "Ok");
        }
    }
}
