using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuSeletor : MonoBehaviour {

	EventSystem sistema;
	GameObject last_obj;

	void Start(){
		sistema = GameObject.Find ("EventSystem").GetComponent<EventSystem> ();
		Destroy(GameObject.Find ("Tempo_de_Jogo"));
	}

	void FixedUpdate(){
		if (sistema.currentSelectedGameObject != null)
			last_obj = sistema.currentSelectedGameObject;

		if (sistema.currentSelectedGameObject == null)
			sistema.SetSelectedGameObject(last_obj, null);
	}

	public void Loader(string cena){
		UnityEngine.SceneManagement.SceneManager.LoadScene (cena);
	}

	public void Quiter(){
		Application.Quit ();
	}
}
