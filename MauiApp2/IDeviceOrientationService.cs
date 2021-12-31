using Microsoft.Maui.Essentials;

namespace MauiApp2;

// Interface to be used in dependency injection.
public interface IDeviceOrientationService
{
    DisplayOrientation GetOrientation();
}
