using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
     float steerSpeed = 200f;
     float driveSpeed = 20f;
     float slowSpeed = 15f;
     float RoadSpeed = 20f;
     float offRoadSpeed = 8f;
    float FastSpeed = 30f;
    

    // Update is called once per frame
    void Update()
    {
        //driving is not logical. logic need to be added to create a logical driving mechanic such as no turning without driving and proper reverse mechanics
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float DriveAmount = Input.GetAxis("Vertical")   * driveSpeed * Time.deltaTime;
        if(DriveAmount > 0)
        {
            transform.Rotate(0,0,-steerAmount); 
        }
        if(DriveAmount < 0)
        {
            transform.Rotate(0,0,steerAmount); 
        }         
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
        if(other.tag == "Road" && driveSpeed != FastSpeed)
        {            
            driveSpeed = RoadSpeed;
        }

    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Road" )
        {            
            driveSpeed = offRoadSpeed;
        }
    }

}
