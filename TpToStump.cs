using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace YellowWaters_MenuV1.Mods
{
    class TpToStump
    {
        public static void TpToStumpMod()
        {
            bool rPrimary = ControllerInputPoller.instance.rightControllerPrimaryButton;
            var headColliderROT = GorillaLocomotion.GTPlayer.Instance.headCollider.gameObject.transform.rotation;

            Vector3 StumpPOS = new Vector3(-66.4848f, 11.8871f, -82.6619f);

            if (GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom").activeSelf && rPrimary)
            {
                GorillaLocomotion.GTPlayer.Instance.TeleportTo(StumpPOS, headColliderROT);
            }
        }
    }
}
