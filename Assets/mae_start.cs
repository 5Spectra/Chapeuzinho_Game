using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mae_start : MonoBehaviour {

	public GameObject e_btn, text_box;

	[TextArea()]
	public string[] falas; 

	void Start () {
		e_btn.SetActive(false);
		text_box.SetActive (false);
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		e_btn.SetActive(true);

	}

	void OnTriggerExit2D (Collider2D coll){
		e_btn.SetActive(false);
		text_box.SetActive (false);
	}
}
