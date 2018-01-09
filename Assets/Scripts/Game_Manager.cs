using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour {


	void Awake () {
		DontDestroyOnLoad (gameObject);
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");
	}
	

}
