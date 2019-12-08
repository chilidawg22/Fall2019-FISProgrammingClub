using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{

    public GameObject Ball;

    void Update(){
        //launch();
    }

    public void launch(){
        Ball.transform.position = transform.position;
        Ball.SetActive(true);
        Ball.GetComponent<Rigidbody>().AddForce(transform.forward/200, ForceMode.Impulse);
    }
}