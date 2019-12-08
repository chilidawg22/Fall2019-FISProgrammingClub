using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaycastMaster : MonoBehaviour
{

    public GameObject indicator;
    public GameObject ball;
    public Material no;
    public Material yes;
    public float timeOnTarget;
    LineRenderer line;
    public GameObject Launchers;

    void Start(){

        line = GetComponent<LineRenderer>();
    }

    void FixedUpdate() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward /*transform.eulerAngles*/, out hit)) {
            indicator.transform.position = hit.point;            
            //Debug.Log(hit.point.x + ", " + hit.point.y + ", " + hit.point.z);

            //Debug.Log("indicator " + indicator.transform.position.x + ", " + indicator.transform.position.y + ", " + indicator.transform.position.z);
            Collider hitC = hit.collider;
            if (hitC.transform.gameObject.tag == "Ball") {
                //Debug.Log("hit!");
                indicator.GetComponent<Renderer>().material = yes;
                if(!Launchers.GetComponent<BallLauncherController>().activated){
                    timeOnTarget += Time.deltaTime;
                }
            } else {
                indicator.GetComponent<Renderer>().material = no;
            }
        }
        else{
            indicator.GetComponent<Renderer>().material = no;
        }
    }
}