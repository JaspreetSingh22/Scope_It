using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour
{
    public GravityAttractor attractor;
    private Transform myTransform;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        attractor = GameObject.Find("Planet").GetComponent<GravityAttractor>();
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        myRigidbody.useGravity = false;
        myTransform = transform;   
    }

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(myTransform, myRigidbody);
    }
}
