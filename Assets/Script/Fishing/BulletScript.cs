using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	GunScript gun;
	public LineRenderer line;

	// Use this for initialization
	void Start () 
	{
		gun = GameObject.FindGameObjectWithTag("Gun").GetComponent<GunScript>();	
		line.enabled = true;	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "box")
		{
			gun.TargetHit(col.gameObject);
		}
		
		if(col.gameObject.tag == "hijaiyah")
		{
			gun.TargetHit(col.gameObject);
		}

		Destroy(gameObject);
	}
}
