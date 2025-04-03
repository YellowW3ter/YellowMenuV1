using System;
using System.Collections.Generic;
using System.Text;

namespace YellowWaters_MenuV1.Mods
{
    class DayTime
    {
        public static void DayTimeMod()
        {
            BetterDayNightManager.instance.SetTimeOfDay(3);
        }
    }
}
