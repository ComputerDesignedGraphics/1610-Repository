using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;

    public GameObject lazerBolt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 // Sets Horizontal input to receive values from keyboard/player input
        horizontalInput = Input.GetAxis("Horizontal");
        
//Moves Player left or right by the amount of speed programmed
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        // Keeps player from scrolling off-screen (left side)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Keeps player from scrolling off-screen (right side)
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Create Lazerbolt at the blaster transform position (origination - mainting object rotation) 
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
            
    }
}
