using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace YellowWaters_MenuV1.Mods
{
    class WalkWalk
    {
        public static void WallWalk()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.GTPlayer.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.GTPlayer.Instance.bodyCollider.transform.right * (Time.deltaTime * (4.3f / Time.deltaTime)), ForceMode.Acceleration);
            }

            if (ControllerInputPoller.instance.leftGrab)
            {
                GorillaLocomotion.GTPlayer.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.GTPlayer.Instance.bodyCollider.transform.right * (Time.deltaTime * (-4.3f / Time.deltaTime)), ForceMode.Acceleration);
            }

            if (ControllerInputPoller.instance.rightGrab && ControllerInputPoller.instance.leftGrab)
            {
                GorillaLocomotion.GTPlayer.Instance.bodyCollider.attachedRigidbody.AddForce(GorillaLocomotion.GTPlayer.Instance.bodyCollider.transform.forward * (Time.deltaTime * (4.3f / Time.deltaTime)), ForceMode.Acceleration);
            }
        }
    }
}
