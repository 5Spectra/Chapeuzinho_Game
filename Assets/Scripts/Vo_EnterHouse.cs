using UnityEngine;
using System.Collections;

public class Vo_EnterHouse : MonoBehaviour
{
	
	public GameObject e_btn, cam, jogador;
	bool perto;
	public static int entra_sai;	//0 = Lado de Fora | 1 = entrou | 2 = Saio

	void Start () {
		e_btn.SetActive(false);
	}

	void Update(){

		//entrar na casa
		if (Input.GetAxisRaw ("Interagir") > 0 && perto == true && entra_sai == 0)
		{
			cam.transform.position = new Vector3 (198.85f, cam.transform.position.y, cam.transform.position.z);
			jogador.transform.position = new Vector3 (193f, jogador.transform.position.y);
			entra_sai = 1;
			GameObject.Find("Casa_Vo").GetComponent<Conversa_1>().enabled = true;

			GetComponent<Vo_EnterHouse> ().enabled = false;
		}

		//sair da casa
		if (Input.GetAxisRaw ("Interagir") > 0 && perto == true && entra_sai == 2)
		{
			cam.transform.position = new Vector3 (160.65f, cam.transform.position.y, cam.transform.position.z);
			jogador.transform.position = new Vector3 (167f, jogador.transform.position.y);
			entra_sai = 3;
		}
	}


	void OnTriggerStay2D(Collider2D coll) {

		if (entra_sai == 0 || entra_sai == 2) {
			e_btn.SetActive (true);
			perto = true;
		}
		else {
			e_btn.SetActive (false);
			perto = false;
		}
	}

	void OnTriggerExit2D (Collider2D coll){
		e_btn.SetActive(false);
		perto = false;
	}
}

