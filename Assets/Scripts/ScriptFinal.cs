using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptFinal : MonoBehaviour {

	public Text txt_tempo, txt_doces;

	void Start () {
		txt_doces.text = "Você coletou " + Player_Collisions.Doce_Count.ToString() + " de 40 doces";
		txt_tempo.text = "Completou o jogo em " + Mathf.Round(Tempo_Jogo.Tempo / 60).ToString() + " minutos";
			
		Destroy (GameObject.Find("Tempo_de_Jogo"));
	}
}
