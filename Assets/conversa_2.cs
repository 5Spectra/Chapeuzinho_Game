using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conversa_2 : MonoBehaviour {

	bool axisDown;

	public Animator chapeu, lenhador, lobo; 

	public GameObject Dialogos, dialogo1, dialogo2, combat;

	public GameObject btn1, btn2; 

	public Text text1, text2;
	 
	int conversa_level, num_conversa;

	[TextArea(1,3)]
	public string[] falasC1, falasC2;

	void Start () {

		if (JoyStick_detection.isJoyConnect == true){
			btn1.GetComponentInChildren<Text>().text = "B";
			btn2.GetComponentInChildren<Text>().text = "B"; 
		}

		num_conversa = 1;
		conversa_level = 0;

		dialogo1.SetActive (false);
		dialogo2.SetActive (false);
		lobo.enabled = false;
	}

	void Update () {

		print ("level " + conversa_level + " | num " + num_conversa + " | Falas " + falasC1.Length);

		if (Input.GetAxisRaw ("Interagir") > 0)
			if (axisDown == false){
				conversa_level++;
				axisDown = true;
			}

		if (Input.GetAxisRaw ("Interagir") == 0)
			axisDown = false;

		//conversa entre chapeu e lenhador
		if (num_conversa == 1) {
			if (conversa_level == 0) StartCoroutine (Wait_Chapeu ());

			if (conversa_level < falasC1.Length) text1.text = falasC1[conversa_level];

			if (conversa_level == falasC1.Length) {
				num_conversa = 2;
				conversa_level = 0;
			}

		}

		//conversa entre lenhador e lobo
		if (num_conversa == 2) {
			
			if (conversa_level == 0) StartCoroutine (Wait_Lobo ());

			if (conversa_level < falasC2.Length) text2.text = falasC2 [conversa_level];

			if (conversa_level == falasC2.Length) {
				num_conversa = 3;
				conversa_level = 0;
			}
		}

		//fim da conversa
		if (num_conversa == 3) {
			Dialogos.SetActive (false);
			combat.SetActive (true);
			GetComponent<conversa_2> ().enabled = false;
		}

	}

	IEnumerator Wait_Chapeu(){

		yield return new WaitForSeconds (2f);
		dialogo1.SetActive (true);
		//conversa_level = 0;
	}

	IEnumerator Wait_Lobo(){
		lobo.enabled = true;
		lenhador.SetBool ("Olhar_lobo", true);
		dialogo1.SetActive(false);

		yield return new WaitForSeconds (2f);

		dialogo2.SetActive (true);
		//conversa_level = 0;
	}

}
