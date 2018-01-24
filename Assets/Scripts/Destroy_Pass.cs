using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Pass : MonoBehaviour {

	public GameObject[] plataformas;

	void Start () {
		for (int i = 0; i < plataformas.Length; i++) {
			Destroy (plataformas[i]);
		}
	}



}
