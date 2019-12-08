using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class BallLauncherController : MonoBehaviour
{

        public SteamVR_Input_Sources player;


public double delay = 0;
private double Timesince = 0;
private double TimeSinceLastLaunch = 0;
public double timer = 5;
public GameObject Ball;
private GameObject[] launchers;
public bool activated = true;

    void Start()
    {
        launchers = GameObject.FindGameObjectsWithTag("BallLauncher");
        //launchers[Random.Range(0, launchers.Length)].GetComponent<BallLauncher>().launch();
    }

    void Update()
    {
        if (SteamVR_Actions._default.TestTrigger.GetStateDown(player) || Time.time - TimeSinceLastLaunch >= timer){
            print("ÿes");
            activated = true;
            Timesince = Time.time;
            TimeSinceLastLaunch = Time.time;
        }

       if(Time.time - Timesince >= delay && activated){
           launchers[Random.Range(0, launchers.Length)].GetComponent<BallLauncher>().launch();
           TimeSinceLastLaunch = Time.time;
           activated = false;
       } 
    }
}
