using Application = Microsoft.Maui.Controls.Application;

namespace MauiApp2;

public partial class App : Application
{
    // Inject MainPage instead of instantiating it here
    public App(MainPage page)
    {
        InitializeComponent();
        MainPage = page;
    }
}
