using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morte : MonoBehaviour {


	void OnCollisionEnter2D (Collision2D coll){

		if (coll.gameObject.tag == "Player") {
			//print("morreu");
			Destroy (coll.gameObject);
			Vo_EnterHouse.entra_sai = 0;
			Destroy(GameObject.Find ("Tempo_de_Jogo"));
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Death");
		}
	}
}
