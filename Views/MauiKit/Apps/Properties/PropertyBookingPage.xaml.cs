namespace MauiKit.Views.Properties;

public partial class PropertyBookingPage : BasePage
{
	public PropertyBookingPage()
	{
		InitializeComponent();
		BindingContext = new PropertyBookingViewModel();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

#if !WINDOWS
        var hanaLoc = new Location(50.8514, 5.6910);

        MapSpan mapSpan = MapSpan.FromCenterAndRadius(hanaLoc, Distance.FromKilometers(1));
        map.MoveToRegion(mapSpan);

        map.Pins.Add(new Pin
        {
            Label = "Welcome to MAUIKIT!",
            Location = hanaLoc,
        });
#endif
    }
}