using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(150,255,150,255);
    [SerializeField] Color32 noPackageColor  = new Color32(255,255,255,255);
    public TextMeshProUGUI DeliveryText;
    public bool firstPackage;
    bool hasPackage; // bools default to false.
    SpriteRenderer spriteRenderer;
    float destroydelay =  0.2f;
    int completedDeliveries = 0;
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();   
        //DeliveryText.text = "Deliveries: " + completedDeliveries;
    }
   
    private void OnTriggerEnter2D(Collider2D other) 
    {
        //if the thing we trigger is package then print package picked up
        if(other.tag == "Package" && !hasPackage) //need to not already have a package
        {
            //Debug.Log("Package");
            hasPackage      = true;
            firstPackage    = true;
            Destroy(other.gameObject, destroydelay);
            spriteRenderer.color = hasPackageColor;
        }
        if(other.tag == "Customer" && hasPackage)
        {
            //Debug.Log("Dropped");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            completedDeliveries += 1;
            DeliveryText.text = "Deliveries: " + completedDeliveries;

            if(completedDeliveries > 3){
                firstPackage    = false;
            }
        }       

    }


}
