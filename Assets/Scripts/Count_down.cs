using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_down : MonoBehaviour {

	float number = 10;
	public Text temporizador;

	void Update () {
		if (number > 0)
			number -= Time.deltaTime;
		else
			SceneManager.LoadScene ("Menu");

		string texto = (Mathf.Round(number)).ToString ();
		temporizador.text = texto;
	}

	public void try_again(){
		SceneManager.LoadScene ("Plataforma");
	}
	public void surrender(){
		SceneManager.LoadScene ("Menu");
	}

}
