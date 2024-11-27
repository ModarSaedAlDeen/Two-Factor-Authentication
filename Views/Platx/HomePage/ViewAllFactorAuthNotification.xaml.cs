using MauiKit.Models;
using System.Collections.ObjectModel;


namespace MauiKit.Views.Platx.HomePage;

public partial class ViewAllFactorAuthNotification : ContentPage
{
    public ObservableCollection<TransactionData> Notifications { get; set; }

    public ViewAllFactorAuthNotification(ObservableCollection<TransactionData> notifications)
    {
        InitializeComponent();
        Notifications = notifications;
        BindingContext = this;
    }
}