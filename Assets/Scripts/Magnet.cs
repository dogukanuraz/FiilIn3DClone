using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public float magnetForce;
    Transform magnet;
    public Rigidbody cube;

    void Start()
    {
        magnet = transform;
    }
    void FixedUpdate()
    {

        cube.AddForce((magnet.position - cube.position) * magnetForce * Time.fixedDeltaTime);


    }

}
