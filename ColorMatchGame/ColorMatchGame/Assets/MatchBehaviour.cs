using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
   
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
        return;

        var otherID = tempObj.idObj;
        Debug.Log(otherID == idObj ? "Matched" : "No Match");
        
        
    }
}
