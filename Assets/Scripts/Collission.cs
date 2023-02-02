using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collission : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D other) 
   {
        Debug.Log("Eina!");
   }
}
