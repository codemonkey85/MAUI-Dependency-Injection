using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage(IDeviceOrientationService deviceOrientationService)
    {
        InitializeComponent();
        try
        {
            orientationLabel.Text = deviceOrientationService.GetOrientation().ToString();
        }
        catch (NotImplementedException ex) 
        {
            orientationLabel.Text = ex.Message;
        }
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterLabel.Text = $"Current count: {count}";

        SemanticScreenReader.Announce(CounterLabel.Text);
    }
}
