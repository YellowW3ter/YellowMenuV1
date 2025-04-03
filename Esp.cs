using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using UnityEngine;

namespace YellowWaters_MenuV1.Mods
{
    class Esp
    {
        public static bool espEnabled = false;
        public static void DisableChams() { espEnabled = false; }
        public static void SnakeESP()
        {
            Shader ESPShader = Shader.Find("GUI/Text Shader");
            Color ESPColor = GorillaTagger.Instance.offlineVRRig.mainSkin.material.color;
            GameObject Ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject Snake = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            if (PhotonNetwork.InRoom)
            {
                espEnabled = true;
            }
            if (espEnabled == true)
            {
                foreach (VRRig TheRigs in GorillaParent.instance.vrrigs)
                {
                    Ball.GetComponent<Renderer>().material.shader = ESPShader;
                    Snake.GetComponent<Renderer>().material.shader = ESPShader;
                    Ball.GetComponent<Renderer>().material.color = ESPColor;
                    Snake.GetComponent<Renderer>().material.color = ESPColor;

                    Ball.transform.position = TheRigs.transform.position;
                    Snake.transform.position = TheRigs.transform.position;

                    
                    UnityEngine.Object.Destroy(Ball, Time.deltaTime);
                    UnityEngine.Object.Destroy(Ball.GetComponent<BoxCollider>());
                    UnityEngine.Object.Destroy(Ball.GetComponent<Collider>());
                    UnityEngine.Object.Destroy(Ball.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(Snake.GetComponent<BoxCollider>(), 0.01f);
                    UnityEngine.Object.Destroy(Snake.GetComponent<Collider>(), 0.01f);
                    UnityEngine.Object.Destroy(Snake.GetComponent<Rigidbody>(), 0.01f);
                    UnityEngine.Object.Destroy(Snake, 0.45f);
                }
            }
        }
    }
}
