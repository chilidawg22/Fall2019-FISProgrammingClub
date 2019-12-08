using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
public SteamVR_Input_Sources player;


    void Update()
    {
        if (SteamVR_Actions._default.TestTrigger.GetStateDown(player)){
            SceneManager.LoadScene("Level1");
        }

    }
}
