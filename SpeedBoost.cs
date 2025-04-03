using System;
using System.Collections.Generic;
using System.Text;

namespace YellowWaters_MenuV1.Mods
{
    class SpeedBoost
    {
        public static void SpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 9f;
        }
    }
}
    
