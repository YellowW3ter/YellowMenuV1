using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods // Not sure who made this mod, also don't know if it even works
{
    class FlickTag
    {
        public static void FlickTagMod()
        {
            bool rightGrab = ControllerInputPoller.instance.rightGrab;
            if (rightGrab)
            {
                GorillaTagger.Instance.rightHandTransform.position = GorillaTagger.Instance.rightHandTransform.position * 10f;
            }
            bool leftGrab = ControllerInputPoller.instance.leftGrab;
            if (leftGrab)
            {
                GorillaTagger.Instance.leftHandTransform.position = GorillaTagger.Instance.leftHandTransform.position * 10f;
            }
        }
    }
}
