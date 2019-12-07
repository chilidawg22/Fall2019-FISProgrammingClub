using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastMaster : MonoBehaviour
{

    public GameObject indicator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.eulerAngles, out hit)) {
            indicator.transform.position = hit.point;
        }
    }
}
