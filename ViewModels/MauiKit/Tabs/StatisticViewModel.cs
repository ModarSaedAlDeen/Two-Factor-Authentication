﻿using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using MauiKit.Controls.Charts;
using SkiaSharp;

namespace MauiKit.ViewModels;
public partial class StatisticViewModel : ObservableObject
{
    public StatisticViewModel()
    {
        LoadData();
    }

    public void LoadData()
    {
        Task.Run(async () =>
        {
            // await api call;
            await Task.Delay(1000);
            Application.Current.Dispatcher.Dispatch(() =>
            {
                ChartData = new ObservableCollection<ISeries>
                {
                    new PieSeries<int> { Name = "Pending", Values = new List<int> { 2 }, MaxRadialColumnWidth = 60 },
                    new PieSeries<int> { Name = "Delivered", Values = new List<int> { 4 }, MaxRadialColumnWidth = 60 },
                    new PieSeries<int> { Name = "Cancelled", Values = new List<int> { 1 }, MaxRadialColumnWidth = 60 },
                    new PieSeries<int> { Name = "Returned", Values = new List<int> { 4 }, MaxRadialColumnWidth = 60 }
                };

                NewAnnouncements = new ObservableCollection<NewAnnouncementData>(DemoAppServices.Instance.GetNewAnnouncements);

                BannerItems = new ObservableCollection<BannerData>(DemoAppServices.Instance.GetBannerItems);

                LegendTextPaint = new SolidColorPaint
                {
                    Color = new SKColor(110, 110, 110),
                    SKTypeface = SKTypeface.FromFamilyName("Arial")
                };
            });
        });
    }

    public ChartEntry[] ChartEntries { get; set; } =
        {
        new ChartEntry
        {
            Value = 65,
            Color = Color.FromArgb("#f77400"),
            Text = "Pending"
        },
        new ChartEntry
        {
            Value = 33,
            Color = Color.FromArgb("#3abe63"),
            Text = "Delivered"
        },
        new ChartEntry
        {
            Value = 25,
            Color = Color.FromArgb("#f13421"),
            Text = "Cancelled"
        },
        new ChartEntry
        {
            Value = 12,
            Color = Color.FromArgb("#0075bd"),
            Text = "Returned"
        }
    };

    [ObservableProperty]
    private ObservableCollection<ISeries> _chartData;

    [ObservableProperty]
    private ObservableCollection<NewAnnouncementData> _newAnnouncements;

    [ObservableProperty]
    public ObservableCollection<BannerData> _bannerItems;
    
    [ObservableProperty]
    public SolidColorPaint _legendTextPaint;
}