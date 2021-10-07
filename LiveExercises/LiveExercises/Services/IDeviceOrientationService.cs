using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace LiveExercises.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetDeviceOrientation();
    }
}
