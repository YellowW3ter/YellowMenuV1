using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace YellowWaters_MenuV1.Mods
{
    class Fly
    {
        public static void flyMod()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += (GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;


            }
        }
    }
}                                                                                           
    

