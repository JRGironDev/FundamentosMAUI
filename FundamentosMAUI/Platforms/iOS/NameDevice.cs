﻿using System;
namespace FundamentosMAUI
{
	public partial class NameDevice
	{
		public partial string GetName()
		{
            return Guid.NewGuid().ToString();
        }
    }
}

