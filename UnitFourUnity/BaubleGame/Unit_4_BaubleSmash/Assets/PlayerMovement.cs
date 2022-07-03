using UnityEngine;

        public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    
    void FixedUpdate ()  // Update is called once per frame
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   // Adds Z-Axis movement 

        if (Input.GetKey("d")) //Add force to left & right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if ( Input.GetKey("a"))  //Add force to left & right
        {   
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}