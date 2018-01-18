using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool perseguicao;

	void Awake () {
		DontDestroyOnLoad (gameObject);
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");
	}



}
