using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D Other) {

		if(Other.GetComponent<Bird> () != null)
		{
			Debug.Log("Hello it's me");
			GameControl.instance.BirdScored();
		}

	}
}
