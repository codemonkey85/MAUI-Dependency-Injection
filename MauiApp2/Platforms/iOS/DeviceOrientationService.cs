using Microsoft.Maui.Essentials;
using UIKit;

namespace MauiApp2.Platforms
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DisplayOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;
            bool isPortrait = orientation == UIInterfaceOrientation.Portrait || orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DisplayOrientation.Portrait : DisplayOrientation.Landscape;
        }
    }
}
