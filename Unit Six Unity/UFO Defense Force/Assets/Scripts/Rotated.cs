using UnityEngine;

  public class Rotated : MonoBehaviour
{
  float speed = 50.0f;


        // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
