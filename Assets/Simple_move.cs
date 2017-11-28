using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_move : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public bool isJumping;

	Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	void FixedUpdate () {

		float x = Input.GetAxisRaw ("Horizontal") * Time.fixedDeltaTime;

		print ("x: " + x);

		rb.AddForce (Vector2.right * x * moveSpeed);

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.JoystickButton0))
			if (isJumping == false) {
				rb.AddForce (Vector2.up * jumpHeight);
				
			}
	}

	void OnCollisionStay2D (Collision2D coll){
		isJumping = false;
	}

	void OnCollisionExit2D (Collision2D coll){
		isJumping = true;
	}
}
