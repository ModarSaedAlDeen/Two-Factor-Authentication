﻿
namespace MauiKit.ViewModels.Onboardings;
public partial class DemoWalkthroughViewModel : ObservableObject
{
    private INavigation _navigationService;
    private Page _pageService;
    public DemoWalkthroughViewModel(INavigation navigationService, Page pageService)
    {
        _navigationService = navigationService;
        _pageService = pageService;

        Boardings = new ObservableCollection<Boarding>();
        CreateBoardingCollection();
    }

    void CreateBoardingCollection()
    {
        Boardings = new ObservableCollection<Boarding>()
        {
            new Boarding
            {
                ImagePath = MauiKitIcons.Table,
                Title = LocalizationResourceManager.Translate("StringWalkthroughDemoTitleStep1"),
                Subtitle = LocalizationResourceManager.Translate("StringWalkthroughDemoSubtitleStep1")
            },
            new Boarding
            {
                ImagePath = MauiKitIcons.TableEdit,
                Title = LocalizationResourceManager.Translate("StringWalkthroughDemoTitleStep2"),
                Subtitle = LocalizationResourceManager.Translate("StringWalkthroughDemoSubtitleStep2")
            },
            new Boarding
            {
                ImagePath = MauiKitIcons.CodeTagsCheck,
                Title = LocalizationResourceManager.Translate("StringWalkthroughDemoTitleStep3"),
                Subtitle = LocalizationResourceManager.Translate("StringWalkthroughDemoSubtitleStep3")
            }
        };
    }

    #region Commands

    [RelayCommand]
    private async void Skip(object obj)
    {
        await CloseWalkThroughPage();
    }

    [RelayCommand]
    private async void Next(object obj)
    {
        if (ValidateAndUpdatePosition())
        {
            await CloseWalkThroughPage();
        }

    }
    #endregion

    #region Methods
    private bool ValidateAndUpdatePosition()
    {
        ValidateSelection(Position + 1);
        if (Position >= Boardings.Count - 1)
            return true;
        Position = Position + 1;
        return false;
    }

    private void ValidateSelection(int index)
    {
        if (index <= Boardings.Count - 2)
        {
            IsSkipButtonVisible = true;
            NextButtonText = AppTranslations.ButtonNext;
        }
        else
        {
            NextButtonText = AppTranslations.ButtonFinish;
            IsSkipButtonVisible = false;
        }
    }

    private async Task CloseWalkThroughPage()
    {
        //Application.Current.MainPage = new LoginPage();
        //await Navigation.PushAsync(new ForgotPasswordPage());
        if (Application.Current.MainPage is NavigationPage navPage)
        {
            await navPage.PushAsync(new LoginPage());
        }
        else
        {
            Application.Current.MainPage = new NavigationPage(new ForgotPasswordPage());
        }
    }

    #endregion

    #region Properties

    [ObservableProperty]
    public ObservableCollection<Boarding> _boardings;

    [ObservableProperty]
    private bool _isSkipButtonVisible = true;

    [ObservableProperty]
    private int _position = 0;

    [ObservableProperty]
    private string _nextButtonText = AppTranslations.ButtonNext;

    #endregion
}