using System;
using Android.Content;
using Android.Locations;
using Android.Runtime;

namespace FundamentosMAUI
{
	public partial class NameDevice
	{
        public partial string GetName()
        {
            var locationManager = Android.App.Application.Context
                .GetSystemService(Context.LocationService)
                .JavaCast<LocationManager>();

            return locationManager.GnssHardwareModelName;
        }
    }
}

