using Microsoft.Maui.Essentials;
using UIKit;

// Removed the platform folder name from the namespace to avoid ambiguity with Microsoft.Maui platform name,
// and so that implementations can all live in the same namespace. Specific implementations will only be
// compiled for their associated target platforms so no conflicts should occur.
namespace MauiApp2.Platforms;

public class DeviceOrientationService : IDeviceOrientationService
{
    public DisplayOrientation GetOrientation()
    {
        UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;
        bool isPortrait = orientation == UIInterfaceOrientation.Portrait || orientation == UIInterfaceOrientation.PortraitUpsideDown;
        return isPortrait ? DisplayOrientation.Portrait : DisplayOrientation.Landscape;
    }
}
