using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GameController : MonoBehaviour
{
    

    public SteamVR_Input_Sources player;
    public GameObject ball;
    Vector3 position = new Vector3(1,1,1); 
    Quaternion rotation = new Quaternion(0,0,0,0);


    void Update()
    {
        if (SteamVR_Actions._default.TestTrigger.GetStateDown(player)){
            Instantiate(ball, position, rotation);
        }

    }
}
