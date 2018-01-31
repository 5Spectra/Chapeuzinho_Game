using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversa_3 : MonoBehaviour {

	bool axisDown, first;
	int conversa_level;

	public Animator chapeu, lenhador, vovo, carvas, Creditos; 
	public GameObject Dialogo, Cam;
	public Text texto, falando;

	[TextArea(1,3)]
	public string[] falas;
	public string[] falador;

	void Start () {
		conversa_level = 0;
	}
	

	void Update () {
		if (Input.GetAxisRaw ("Interagir") > 0)
		if (axisDown == false){
			conversa_level++;
			axisDown = true;
		}

		if (Input.GetAxisRaw ("Interagir") == 0)
			axisDown = false;

		if (conversa_level < falas.Length) {
			texto.text = falas [conversa_level];
			falando.text = falador [conversa_level];
		}

		if (conversa_level == falas.Length && first == false) StartCoroutine (Wait_Exit ());
	}

	IEnumerator Wait_Exit(){
		first = true;

		chapeu.enabled = true;
		vovo.enabled = true;
		lenhador.enabled = true;
		carvas.enabled = true;

		Destroy (Dialogo, 1);

		yield return new WaitForSeconds (4f);

		Cam.transform.position = new Vector3 (0,0, Cam.transform.position.z);

		yield return new WaitForSecondsRealtime (2f);

		Creditos.enabled = true;
		GetComponent<Conversa_3> ().enabled = false;

	}
}
