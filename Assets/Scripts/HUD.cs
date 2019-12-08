using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{

    public GameObject RayCast;
    public GameObject LaunchersObject;
    private BallLauncherController Launcher;
    private RaycastMaster Ray;
    public double duration;
    public GameObject TextObj;
    private Text text;
    public GameObject TotTextObj;
    private Text TotText;

    // Start is called before the first frame update
    void Start()
    {
        Launcher = LaunchersObject.GetComponent<BallLauncherController>();
        Ray = RayCast.GetComponent<RaycastMaster>();
        text = TextObj.GetComponent<Text>();
        TotText = TotTextObj.GetComponent<Text>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(!Launcher.activated){
            duration += Time.deltaTime;
        }
        text.text = "TOT: " + Ray.timeOnTarget.ToString("F1");
        TotText.text = "Elapsed: " + duration.ToString("F1");
    }
}
