using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastMaster : MonoBehaviour
{

    public GameObject indicator;

  
    void FixedUpdate() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.forward /*transform.eulerAngles*/, out hit)) {
            indicator.transform.position = hit.point;
            Debug.Log(hit.point.x + ", " + hit.point.y + ", " + hit.point.z);

            Debug.Log("indicator " + indicator.transform.position.x + ", " + indicator.transform.position.y + ", " + indicator.transform.position.z);
        }
    }
}
