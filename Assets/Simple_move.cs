using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_move : MonoBehaviour {

	Rigidbody2D rb;

	void Start () {

		rb = GetComponent<Rigidbody2D> ();
	}
	
	void FixedUpdate () {

		float x = Input.GetAxis ("Horizontal"); //* Time.fixedDeltaTime;
			float y = Input.GetAxis ("Vertical");// * Time.fixedDeltaTime;

		print (x);
		rb.AddForce (Vector2.right, );
	}
}
