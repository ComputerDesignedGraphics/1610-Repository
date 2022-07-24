using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMoveDown : MonoBehaviour
{
    public float speed = 30.0f;
    
    // Update is called once per frame
    void Update()
    {
        // Move lazer blaster forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}