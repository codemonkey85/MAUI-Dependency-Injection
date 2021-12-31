﻿using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage(IDeviceOrientationService deviceOrientationService)
    {
        InitializeComponent();
        orientationLabel.Text = deviceOrientationService.GetOrientation().ToString();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterLabel.Text = $"Current count: {count}";

        SemanticScreenReader.Announce(CounterLabel.Text);
    }
}
