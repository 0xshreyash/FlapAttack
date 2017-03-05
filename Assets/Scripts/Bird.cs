using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	public float upForce = 200f;
	private bool isDead = false;
	private Rigidbody2D rb2d;
	private Animator anim;
	const int LEFT = 0;
	// Use this for initialization
	public void Start () {

		rb2d = GetComponent<Rigidbody2D> (); 
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	public void Update () {
		if(!isDead)
		{
			if(Input.GetMouseButtonDown(LEFT))
			{
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, upForce)); 
				anim.SetTrigger("Flap");
			}
		}
		
	}

	public void OnCollisionEnter2D()
	{

		rb2d.velocity = Vector2.zero;
		isDead = true;
		anim.SetTrigger("Die");
		GameControl.instance.BirdDied();

	}
}
