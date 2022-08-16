using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

	public GameObject Bullet;

	public float BulletSpeed;

	public Transform ShootPoint;

	Vector2 Direction;

	public LineRenderer line;

	GameObject target;

	public SpringJoint2D spring;

	

	// Use this for initialization
	void Start () 
	{
		line.enabled = false;	
		spring.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		Direction = MousePos - (Vector2)transform.position;	

		FaceMouse();

		if(Input.GetMouseButtonDown(0))
		{
			Shoot();
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			Release();
		}

		if(target != null)
		{
			line.SetPosition(0,ShootPoint.position);
			line.SetPosition(1,target.transform.position);
		}
	}

	void FaceMouse()
	{
		transform.right = Direction;
	}

	void Shoot()
	{
		GameObject BulletIns =  Instantiate(Bullet,ShootPoint.position,Quaternion.identity);

		BulletIns.GetComponent<Rigidbody2D>().AddForce(transform.right * BulletSpeed);
	}

	public void TargetHit(GameObject hit)
	{
		target = hit;
		line.enabled = true;
		spring.enabled = true;
		spring.connectedBody = target.GetComponent<Rigidbody2D>();
		
	}

	void Release()
	{
		line.enabled = false;
		spring.enabled = false;
		target = null;
	}
}
