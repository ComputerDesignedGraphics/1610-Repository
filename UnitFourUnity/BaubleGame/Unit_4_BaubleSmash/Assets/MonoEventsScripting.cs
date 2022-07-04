
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;

	private void Awake()
	{
		awakeEvent.Invoke();
	}
	
	private void Start()
	{
		startEvent.Invoke();
	}

	private void OnDisable()
	{
		disableEvent.Invoke()
	}
}
//wrote new scripts - will utilize them inside the Bauble Game - have ideas to use some of the new events