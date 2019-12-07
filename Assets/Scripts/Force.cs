using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 forceDirection = new Vector3(1,1,0);

    


    void Start()
    {
        GetComponent<Rigidbody>().AddForce(forceDirection, ForceMode.VelocityChange);
    }

    
}
