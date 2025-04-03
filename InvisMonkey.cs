using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace YellowWaters_MenuV1.Mods
{
    class InvisMonkey
    {
        public static void InvisMonke()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                {
                    GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(0f, 0f, 0f);
                }
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}

