using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conversa_2 : MonoBehaviour {

	bool axisDown, first;

	public Animator chapeu, lenhador, lobo; 

	public GameObject Dialogos, dialogo1, dialogo2, combat;

	public GameObject btn1, btn2; 

	public Text text1, text2, falando1, falando2;
	 
	int conversa_level, num_conversa;

	[TextArea(1,3)]
	public string[] falasC1, falasC2;
	public string[] conv1F, conv2F;

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

		//print ("level " + conversa_level + " | num " + num_conversa + " | Falas " + falasC1.Length);

		if (Input.GetAxisRaw ("Interagir") > 0)
			if (axisDown == false){
				conversa_level++;
				axisDown = true;
			}

		if (Input.GetAxisRaw ("Interagir") == 0)
			axisDown = false;

		//conversa entre chapeu e lenhador
		if (num_conversa == 1) {
			if (conversa_level == 0 && first == false) StartCoroutine (Wait_Chapeu ());

			if (conversa_level < falasC1.Length) {
				text1.text = falasC1 [conversa_level];
				falando1.text = conv1F [conversa_level];
			}

			if (conversa_level >= falasC1.Length) {
				conversa_level = 0;
				num_conversa = 2;
				first = false;
			}

		}

		//conversa entre lenhador e lobo
		if (num_conversa == 2) {
			
			if (conversa_level == 0 && first == false) StartCoroutine (Wait_Lobo ());

			if (conversa_level < falasC2.Length) {
				text2.text = falasC2 [conversa_level];		
				falando2.text = conv2F [conversa_level];
			}

			if (conversa_level >= falasC2.Length) {
				conversa_level = 0;
				num_conversa = 3;
			}
		}

		//fim da conversa
		if (num_conversa == 3) {
			//Dialogos.SetActive (false);
			combat.SetActive (true);
			Destroy (Dialogos, 1);
			GetComponent<conversa_2> ().enabled = false;
		}

	}

	IEnumerator Wait_Chapeu(){
		first = true;

		yield return new WaitForSeconds (2.5f);
		dialogo1.SetActive (true);
		chapeu.SetBool ("isParada", true);

	}

	IEnumerator Wait_Lobo(){
		first = true;

		dialogo1.SetActive(false);
		lobo.enabled = true;
		lenhador.SetBool ("Olhar_lobo", true);

		yield return new WaitForSeconds (2f);

		lobo.SetBool ("isParado", true);
		dialogo2.SetActive (true);

	}

}
