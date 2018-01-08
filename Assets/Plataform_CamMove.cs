using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform_CamMove : MonoBehaviour {

	public GameObject jogador;
	public float CamMove = 17.85f, num_Cena = 0, total_Cenas;

	void FixedUpdate () {

		float playerP = jogador.transform.localPosition.x; print (playerP);
		float cameraP = gameObject.transform.position.x;

		/*
		if (playerP < CamMove * 1)
			num_Cena = 0;

		if (playerP < CamMove * 2 && playerP > CamMove * 1)
			num_Cena = 1;

		if (playerP < CamMove * 3 && playerP > CamMove * 2)
			num_Cena = 2;
		*/

		for (int i = 1; i < total_Cenas; i++) {

			if (playerP < CamMove * 1)
				num_Cena = 0;

			if (playerP < CamMove * i + 1 && playerP > CamMove * i)
				num_Cena = i;

		}
	}
}

