using UnityEngine;
using UnityEngine.Events


public class TriggerEventBehavior : MonoBehavior

{

	public UnityEvent triggerEnterEvent;

	private void OnTriggerEnter(Collider other)
	{
		triggerEnterEvent.Invoke();
	}

}