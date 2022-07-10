using UnityEngine;

public class HeathMoveDown : MonoBehaviour
{
    public float forceMult = 5;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
            rb.AddForce(transform.forward * forceMult);
    }
    
    // private void Update()
    //{
    //  transform.position += transform.forward * Time.deltaTime;
    //}



}