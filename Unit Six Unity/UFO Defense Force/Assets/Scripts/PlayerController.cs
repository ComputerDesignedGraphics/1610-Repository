using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed;
    
    
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
    }
}
