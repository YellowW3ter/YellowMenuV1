using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    class GhostMonkey
    {
        public static bool ghostMonkeToggle = false;

        public static void GhostMonke()
        {

            if (ControllerInputPoller.instance.leftControllerIndexFloat > 0.1f && !ghostMonkeToggle)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = !GorillaTagger.Instance.offlineVRRig.enabled;
                ghostMonkeToggle = true;
            }
            else if (ControllerInputPoller.instance.leftControllerIndexFloat <= 0.1f)
            {
                ghostMonkeToggle = false;
            }
        }
    }
}
