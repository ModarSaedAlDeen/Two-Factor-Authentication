using System.Diagnostics;

namespace MauiKit.Controls.Commons;

public partial class MaintenancePage : ContentPage
{
	public MaintenancePage()
	{
		InitializeComponent();
	}
    private void OnExitAppClicked(object sender, EventArgs e)
    {
        // ����� �������
        Process.GetCurrentProcess().Kill();
    }
}