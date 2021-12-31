using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MauiApp2.Platforms;

namespace MauiApp2;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Inject the service. Implementation class must be present for all targeted platforms.
        builder.Services.AddTransient<IDeviceOrientationService, DeviceOrientationService>();
        // Inject the MainPage so the service is also injected for us.
        builder.Services.AddTransient<MainPage>();

        return builder.Build();
    }
}
