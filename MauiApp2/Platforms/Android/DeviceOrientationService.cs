using Android.Content;
using Android.Runtime;
using Android.Views;
using Microsoft.Maui.Essentials;

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
