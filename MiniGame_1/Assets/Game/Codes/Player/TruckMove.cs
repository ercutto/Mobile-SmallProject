using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMove : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float tilt;
    Rigidbody rb;
    public GameObject FrontTireLeft, FrontTireRigth;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardMove = (Input.GetAxis("Vertical"));
        float turn = (Input.GetAxis("Horizontal"));
        Vector3 ToForward = rb.transform.forward*forwardMove;
        //rb.AddForce(ToForward*speed);
        rb.velocity = ToForward * speed;
        rb.transform.Rotate(Vector3.up * turn);
        
        

    }
}
