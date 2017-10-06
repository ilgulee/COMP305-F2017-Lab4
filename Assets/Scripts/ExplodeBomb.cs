using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeBomb : MonoBehaviour
{
	public GameObject Explosion;

    public float TimeToExplode = 3.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (TimeToExplode > 0)
	    {
	        TimeToExplode -= Time.deltaTime;
	    }
        else{
			Instantiate(Explosion, transform.position, Quaternion.identity);
			gameObject.SetActive(false);
		}
		
	}
}
