using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{

    public GameObject Ball;
    public float multiplier = 7.5f;

    public void launch(){
        Ball.transform.position = transform.position;
        Ball.GetComponent<Rigidbody>().AddForce(transform.forward*multiplier, ForceMode.Impulse);
    }
}