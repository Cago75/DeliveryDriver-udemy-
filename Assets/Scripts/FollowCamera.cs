using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //This position should follow the car's position
    [SerializeField] GameObject thingToFollow;
    //allows smooth following of car ensuring the update happens at the correct moment
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
