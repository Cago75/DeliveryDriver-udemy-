using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float driveSpeed = 20f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float FastSpeed = 30f;


    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float DriveAmount = Input.GetAxis("Vertical")   * driveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);  
        transform.Translate(0, DriveAmount,0); 
    }
    private void OnCollisionEnter2D(Collision2D other) {
            driveSpeed = slowSpeed;
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        //boostbumpsystem
        if(other.tag == "Boost")
        {
            driveSpeed = FastSpeed;
        }

    }

}
