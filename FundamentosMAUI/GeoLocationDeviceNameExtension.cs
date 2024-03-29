﻿using System;
namespace FundamentosMAUI
{
    public class GeoLocationDeviceNameExtension : IMarkupExtension<string>
    {
        public string ProvideValue(IServiceProvider serviceProvider)
        {
            return new NameDevice().GetName();
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }
}

