using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite_mapa : MonoBehaviour {

	public float x, y;

	void OnCollisionEnter2D (Collision2D coll){

		if (Vo_EnterHouse.entra_sai == 2 && gameObject.name == "Parede Esquerda") {
			Vo_EnterHouse.entra_sai = 0;
			Destroy(GameObject.Find ("Tempo_de_Jogo"));
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Boss_Fight");
		}
		else {
			GameObject player = coll.gameObject;
			player.transform.position = new Vector3 (x, y);
		}
	}
			
}
