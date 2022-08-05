using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class CoRoutineBehaviour : MonoBehaviour
{

	public bool canRun = true;
    IEnumerator Start()
    {
		Debug.Log("Breezy Day!");
        yield return new WaitForSeconds(3);
		Debug.Log("BooChow!");

		while (canRun)
			{
				yield return new WaitForFixedUpdate();
				Debug.Log("Gaaaaaaaaaaaroobers"); 
			}
    }

    // Update is called once per frame
    void Update()
    {
      	 
    }
}
