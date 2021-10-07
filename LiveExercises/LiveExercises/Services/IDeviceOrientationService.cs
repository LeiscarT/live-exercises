using LiveExercises.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace LiveExercises.Services
{
    public interface IDeviceOrientationService
    {
         DeviceOrientation GetDeviceOrientation();
    }
}
