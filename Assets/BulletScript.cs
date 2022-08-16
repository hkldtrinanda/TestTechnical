using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	GunScript gun;

	// Use this for initialization
	void Start () 
	{
		gun = GameObject.FindGameObjectWithTag("Gun").GetComponent<GunScript>();	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "box")
		{
			gun.TargetHit(col.gameObject);
		}

		Destroy(gameObject);
	}
}
