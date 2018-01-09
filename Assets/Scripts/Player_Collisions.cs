using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Collisions : MonoBehaviour {

	[SerializeField]
	int Doce_Count;
	public Text doces;

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag == "doce") {
			Doce_Count += 1;
			doces.text = Doce_Count.ToString ();
			Destroy(coll.gameObject);
		}
	}
}
