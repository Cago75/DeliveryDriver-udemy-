using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float driveSpeed = 20f;


    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float DriveAmount = Input.GetAxis("Vertical")   * driveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);  
        transform.Translate(0, DriveAmount,0); 
    }



}
