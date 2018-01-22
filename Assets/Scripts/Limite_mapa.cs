using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite_mapa : MonoBehaviour {

	public float x, y;

	void OnCollisionEnter2D (Collision2D coll){

		if (GameManager.perseguicao == true && gameObject.name == "Parede Esquerda")
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Boss_Fight");
		else {
			GameObject player = coll.gameObject;
			player.transform.position = new Vector3 (x, y);
		}
	}
			
}
