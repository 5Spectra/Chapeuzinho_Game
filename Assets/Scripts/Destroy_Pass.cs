using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Pass : MonoBehaviour {

	public GameObject[] plataformas;
	public GameObject placa;


	void Start () {
		for (int i = 0; i < plataformas.Length; i++) {
			Destroy (plataformas[i]);
		}

		Destroy (placa, 5f);
	}



}
