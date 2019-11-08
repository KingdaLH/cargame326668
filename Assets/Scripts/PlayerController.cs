using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 5;
    private float horizontalInput;
    private float turnSpeed = 10;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //Reads playerinput
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //rotates the car based on horizontal input
        transform.Translate(Vector3.right * turnSpeed * horizontalInput * Time.deltaTime);

    }
}