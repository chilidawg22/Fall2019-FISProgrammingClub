using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndText : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Time On Target: " + Score.TOT.ToString("F1") +" Out of total time elapsed: 60, Your score is thus: " + ((Score.TOT/60) *100).ToString("F1");

    }
}
