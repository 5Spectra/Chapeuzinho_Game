using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobo_Perseguir : MonoBehaviour {

	public float speed = 1f;

	public Transform player, WayPointsFolder; //set target from inspector instead of looking in Update
	public Transform[] waypoint;

	[SerializeField]
	bool trapaciando;
	[SerializeField]
	int point = 1;

	void Start () {
		waypoint = WayPointsFolder.GetComponentsInChildren<Transform>();
		GetComponent<Animator> ().SetInteger ("Estado", 6);
	}

	void Update(){
		//115.62 - 135.3
		if (transform.position.x < 115){
			if (player.position.x > waypoint[point].position.x) trapaciando = true;
			else trapaciando = false;
		}

		//if (Input.GetKeyDown (KeyCode.R)) trapaciando = !trapaciando;

		if (trapaciando == true)
			if (transform.position != player.position) {
				Vector2 p = Vector2.MoveTowards (transform.position, player.position, speed);
				GetComponent<Rigidbody2D> ().MovePosition (p); 
			}



		if (trapaciando == false && point < waypoint.Length - 1){
			if (transform.position != waypoint[point].position) {
				Vector2 p = Vector2.MoveTowards (transform.position, waypoint[point].position, speed);
				GetComponent<Rigidbody2D> ().MovePosition (p); 
			}
			else 
				point += 1;		
		}
		
	}

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag == "Player")
			print("Kill");
	}

}
