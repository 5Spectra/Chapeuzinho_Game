using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform_CamMove : MonoBehaviour {

	public GameObject cam;
	public float pos_X;

	void OnTriggerExit2D (Collider2D coll){

		cam.transform.position = new Vector3 (pos_X, cam.transform.position.y, cam.transform.position.z);

	}
}

