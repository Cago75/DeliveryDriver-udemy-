using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(150,255,150,255);
    [SerializeField] Color32 noPackageColor  = new Color32(255,255,255,255);
    bool hasPackage; // bools default to false.
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();   
    }
    float destroydelay =  0.2f;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        //if the thing we trigger is package then print package picked up
        if(other.tag == "Package" && !hasPackage) //need to not already have a package
        {
            Debug.Log("Package");
            hasPackage = true;
            Destroy(other.gameObject, destroydelay);
            spriteRenderer.color = hasPackageColor;
        }
        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Dropped");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
        //boostbumpsystem
        if(other.tag == "Boost")
        {

        }
        if(other.tag == "Bump")
        {

        }
        

    }


}
