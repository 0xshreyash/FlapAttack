using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	public float upForce = 200f;
	private bool isDead = false;
	private Rigidbody2D rb2d;
	const int LEFT = 0;
	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> (); 
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!isDead)
		{
			if(Input.GetMouseButtonDown(LEFT))
			{
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, upForce)); 
			}
		}
		
	}

	void onCollisionEnter2D()
	{
		isDead = true;
		return;

	}
}
