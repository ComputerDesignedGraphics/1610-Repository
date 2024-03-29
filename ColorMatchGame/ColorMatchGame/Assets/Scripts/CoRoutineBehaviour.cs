using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class CoRoutineBehaviour : MonoBehaviour
{
	public bool canRun;
	public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;
	public IntData counterNum;
	public float seconds = 3.0f;	
	private WaitForSeconds wfsObj;
	private WaitForFixedUpdate wffoObj;

	private void Start()
	{
		wfsObj = new WaitForSeconds(seconds);
		wffoObj = new WaitForFixedUpdate();
		startEvent.Invoke();
	}


	
	public void StartCounting ()
{
	StartCoroutine(Counting());
}

    private IEnumerator Counting()
    {

		
		
		
		startCountEvent.Invoke();
			yield return wfsObj;
		while (counterNum.value > 0)
		{
			
			repeatCountEvent.Invoke();
			counterNum.value--;
			yield return wfsObj;
		}
		endCountEvent.Invoke();
	}
	public void StartRepeatUntilFalse()
{
	canRun = true;
	StartCoroutine(RepeatUntilFalse());
}


	private IEnumerator RepeatUntilFalse()
	{
		while (canRun)
		{
			yield return wfsObj;
			repeatUntilFalseEvent.Invoke();

		}
	}
}
