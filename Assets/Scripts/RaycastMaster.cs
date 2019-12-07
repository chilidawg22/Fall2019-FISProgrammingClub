using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastMaster : MonoBehaviour
{

    public GameObject indicator;
    public GameObject ball;

  
    void FixedUpdate() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward /*transform.eulerAngles*/, out hit)) {
            indicator.transform.position = hit.point;
            //Debug.Log(hit.point.x + ", " + hit.point.y + ", " + hit.point.z);

            //Debug.Log("indicator " + indicator.transform.position.x + ", " + indicator.transform.position.y + ", " + indicator.transform.position.z);
            Collider hitC = hit.collider;
            Collider ballC = ball.GetComponent<Collider>();
            Debug.Log(hitC);
            Debug.Log(ballC);
            if (hitC == ballC) {
                Debug.Log("hit!");
            }
        }
    }
}