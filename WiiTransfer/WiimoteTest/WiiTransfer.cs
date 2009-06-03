﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WiimoteLib;

namespace WiimoteTest
{
    class WiiTransfer:IWiiTransfer
    {
        public void SendWiimoteData(List<SignalSample> wiidata)
        {
            Window1.wiimote3.AddRange(wiidata);
        }
    }
}