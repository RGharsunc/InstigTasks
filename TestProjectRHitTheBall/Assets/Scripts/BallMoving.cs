using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoving : MonoBehaviour
{

    float speed = 10f;
    float rotateSpeed = 100f;
    private float thrust = 58f;
    private Rigidbody rb;



    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }



    void Update()
    {

        //if(Input.GetMouseButtonDown(0))
        //{
        //}
        //transform.Translate(new Vector3(0, 0, Input.GetAxis("Vertical")*speed*Time.deltaTime));
        //transform.Translate(new Vector3(0, Input.GetAxis("Mouse x") * rotateSpeed * Time.deltaTime, 0));

        //if (Input.GetMouseButton(0))
        //{
        //    //rb.AddForce(transform.forward * thrust);
            
        //}

        if (Input.GetMouseButton(0))
        {
            
            rb.AddForce(Vector3.forward * thrust);
        }
    }
}