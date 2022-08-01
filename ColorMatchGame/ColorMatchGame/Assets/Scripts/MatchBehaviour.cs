using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class MatchBehaviour : IDContainerBehaviour
{
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    
    private IEnumerator OnTriggerEnter(Collider other)

    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if (tempObj == null)
        yield break;
   
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }

    }
}
