using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collisions : MonoBehaviour {

	public

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag == "doce") {
			//pontos += 1;
			Destroy(coll.gameObject);
		}
	}
}
