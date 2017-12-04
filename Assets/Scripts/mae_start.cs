using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mae_start : MonoBehaviour {

	public GameObject e_btn, text_box; 
	public Text texto;

	bool perto, axisDown;
	int num_fala;

	[TextArea()]
	public string[] falas; 

	void Start () {
		e_btn.SetActive(false);
		text_box.SetActive (false);
	}

	void FixedUpdate(){

		if (Input.GetAxisRaw ("Interagir") > 0 && perto)
			if (axisDown == false) {
			text_box.SetActive (true);
			texto.text = falas [num_fala];
			num_fala += 1;
			axisDown = true;
			} 
		if (Input.GetAxisRaw ("Interagir") == 0) {
			axisDown = false;
		}

		if (falas.Length - 1 < num_fala) {
			num_fala = 0;
		}
				
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		e_btn.SetActive(true);
		perto = true;
	}

	void OnTriggerExit2D (Collider2D coll){
		e_btn.SetActive(false);
		text_box.SetActive (false);
		perto = false;
		num_fala = 0;
	}
}
