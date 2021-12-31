using Android.Content;
using Android.Runtime;
using Android.Views;
using Microsoft.Maui.Essentials;

// Removed the platform folder name from the namespace to avoid ambiguity with Microsoft.Maui platform name,
// and so that implementations can all live in the same namespace. Specific implementations will only be
// compiled for their associated target platforms so no conflicts should occur.
namespace MauiApp2.Platforms;

internal class DeviceOrientationService : IDeviceOrientationService
{
    public DisplayOrientation GetOrientation()
    {
        IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
        SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
        bool isLandscape = orientation == SurfaceOrientation.Rotation90 || orientation == SurfaceOrientation.Rotation270;
        return isLandscape ? DisplayOrientation.Landscape : DisplayOrientation.Portrait;
    }
}
