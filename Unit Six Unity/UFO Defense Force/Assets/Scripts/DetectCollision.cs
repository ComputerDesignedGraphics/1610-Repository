using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//If has trigger it will detect collision (Make sure player does not have is Trigger"
        Destroy(other.gameObject);//Destroys two objects - it hits
    }
}
