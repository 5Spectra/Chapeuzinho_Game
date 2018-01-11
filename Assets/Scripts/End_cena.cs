using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_cena : MonoBehaviour {

	public string cena; 

	void OnTriggerEnter2D (Collider2D coll){
		UnityEngine.SceneManagement.SceneManager.LoadScene (cena);
	}
}
