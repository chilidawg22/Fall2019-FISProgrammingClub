using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BallLauncherController : MonoBehaviour
{

        public SteamVR_Input_Sources player;


public double delay = 0;
private double lastCall = 0;
public GameObject Ball;
private GameObject[] launchers;

    void Start()
    {
        launchers = GameObject.FindGameObjectsWithTag("BallLauncher");
        launchers[Random.Range(0, launchers.Length)].GetComponent<BallLauncher>().launch();
        lastCall = Time.time;
    }

    void Update()
    {
        if (SteamVR_Actions._default.TestTrigger.GetStateDown(player)){
            launchers[0].GetComponent<BallLauncher>().launch();
        }
        /*
       if(Time.time - lastCall >= delay && !Ball.activeSelf){
           launchers[0].GetComponent<BallLauncher>().launch();
           lastCall = Time.time;
       } 
       */
    }
}
