using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_move : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public bool isJumping;

	Rigidbody2D rb;
	Animator anim;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	void FixedUpdate () {

		float x = Input.GetAxisRaw ("Horizontal");
		float j = Input.GetAxisRaw ("Jump");

		//if (Input.GetKeyDown (KeyCode.F)) isJumping = !isJumping;

		if (x != 0) {
			anim.SetFloat ("Horizontal", x);
			anim.speed = 1f;
		}
		else
			anim.speed = 0.1f;			

		rb.velocity = new Vector2 (x * moveSpeed, rb.velocity.y);

		if (isJumping == false)
			rb.velocity = new Vector2 (rb.velocity.x , j * jumpHeight);				

	}

	void OnCollisionStay2D (Collision2D coll){
		isJumping = false;
	}

	void OnCollisionExit2D (Collision2D coll){
		isJumping = true;
	}
}
