﻿using Application = Microsoft.Maui.Controls.Application;

namespace MauiApp2;

public partial class App : Application
{
    public App(MainPage page)
    {
        InitializeComponent();
        MainPage = page;
    }
}