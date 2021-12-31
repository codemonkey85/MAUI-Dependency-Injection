using Microsoft.Maui.Essentials;
using System;

// Removed the platform folder name from the namespace to avoid ambiguity with Microsoft.Maui platform name,
// and so that implementations can all live in the same namespace. Specific implementations will only be
// compiled for their associated target platforms so no conflicts should occur.
namespace MauiApp2.Platforms;

public class DeviceOrientationService : IDeviceOrientationService
{
    public DisplayOrientation GetOrientation()
    {
        throw new NotImplementedException();
    }
}
