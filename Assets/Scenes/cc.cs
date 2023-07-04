using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cc : MonoBehaviour
{
    public int speed = 100;
    public int turningSpeed = 20;
     Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
     rb =GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.A))
        //{
        //    rb.AddForce(-turningSpeed * Time.deltaTime, 0f, 0f,ForceMode.VelocityChange);
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.AddForce(turningSpeed * Time.deltaTime, 0f, 0f,ForceMode.VelocityChange);
        //}
        float movement = Input.GetAxis("Horizontal");
        rb.AddForce(turningSpeed * movement * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
    }
}
