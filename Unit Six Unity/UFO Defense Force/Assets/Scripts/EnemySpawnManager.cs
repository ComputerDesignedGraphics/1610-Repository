using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    //Array to store all UFOs
    public GameObject[] ufoPrefabs;
	private float spawnRangeX = 25f;
	private float spawnPosZ = 30f;
       
    // Update is called once per frame
    void Update()
    {
	
		if(Input.GetKeyDown(KeyCode.S))  //If I press S it sends a ship
 		{
			Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
			int ufoIndex = Random.Range(0,ufoPrefabs.Length);  //Sends Random size UFO from Array - you can add even more ships w/out changing code

        Instantiate(ufoPrefabs[ufoIndex],spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //Spawn a indexed UFO from array at random location on X-axis
		}    
	}
}
