using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite_mapa : MonoBehaviour {
	
	void OnCollisionEnter2D (Collision2D coll){

		if (GameManager.perseguicao == true)
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Boss_Fight");
		else {
			GameObject player = coll.gameObject;
			player.transform.position = new Vector3 (-8.5f, -3.5f);
		}
	}
			
}
