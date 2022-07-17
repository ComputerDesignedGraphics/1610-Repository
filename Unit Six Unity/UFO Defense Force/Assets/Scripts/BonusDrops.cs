using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDrops : MonoBehaviour
{
    //Array to store all UFOs
    public GameObject[] BonusDrop;
	private float spawnRangeX = 25f;
	private float spawnPosZ = 30f;
	public float startDelay = 5f;  //can change these both to public so they can be changed in the inspector
	public float spawnInterval = 30.5f;

	void Start()
	{
		InvokeRepeating("SpawnRandomBonusDrop", startDelay, spawnInterval);  //Delay is how long it takes and Spawn Interval is space between
	}
       
    // Update is called once per frame
    void Update()
    {
	    
	}
		void SpawnRandomBonusDrop()
		{
		Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
		int bonusIndex = Random.Range(0,BonusDrop.Length);  //Sends Random size UFO from Array - you can add even more ships w/out changing code
        Instantiate(BonusDrop[bonusIndex],spawnPos, BonusDrop[bonusIndex].transform.rotation); //Spawn a indexed UFO from array at random location on X-axis
		}

}
