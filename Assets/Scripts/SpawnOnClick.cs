using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnClick : MonoBehaviour
{
	public GameObject TimeBomb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			spawnPosition.z = 0.0f;

			GameObject timeBombInstance = Instantiate(TimeBomb, spawnPosition, Quaternion.identity);
		}
	}
}
