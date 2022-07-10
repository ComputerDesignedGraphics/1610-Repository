using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds2 : MonoBehaviour
{
    public float topBounds2 = 40.0f;

    public float lowerBounds2 = -10.0f;
	
    
    void Awake()
    {
        //Time.timeScale = 1;
    }

    // Update is called once per frame

    void Update()
    {
        if(transform.position.z > topBounds2)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds2)
        {
            Debug.Log("Health Pack!");
            Destroy(gameObject);
            //Time.timeScale = 0;
        } 
    }
}