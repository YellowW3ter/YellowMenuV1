using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using UnityEngine;

namespace Yellow_MenuV1.Mods
{
    class AntiReport
    {
        public static void AntiReportMod()
        {
            {
                try
                {
                    foreach (GorillaPlayerScoreboardLine gorillaPlayerScoreboardLine in GorillaScoreboardTotalUpdater.allScoreboardLines)
                    {
                        if (gorillaPlayerScoreboardLine.linePlayer == NetworkSystem.Instance.LocalPlayer)
                        {
                            Transform transform = gorillaPlayerScoreboardLine.reportButton.gameObject.transform;
                            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                            {
                                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                                {
                                    float num = Vector3.Distance(vrrig.rightHandTransform.position, transform.position);
                                    float num2 = Vector3.Distance(vrrig.leftHandTransform.position, transform.position);
                                    float num3 = 0.50f;
                                    if (num < num3 || num2 < num3)
                                    {

                                        PhotonNetwork.Disconnect();


                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
            }
        }

    }
}
    

