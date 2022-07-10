
using UnityEngine;

public class HeathMoveDown : MonoBehaviour
{

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
    
    
    
}