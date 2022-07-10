using UnityEngine;

public class HeathBonus : MonoBehaviour

{
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
    }
}
