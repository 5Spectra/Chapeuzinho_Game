using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tempo_Jogo : MonoBehaviour {

	public static float Tempo;

	void Start () {
		DontDestroyOnLoad(gameObject);
	}

	void Update () {
			Tempo += Time.deltaTime;
	}
}
