using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversa_1 : MonoBehaviour {

	public GameObject jogador, lobo, conversa, volta_way;
	public GameObject chapeu_Fala, lobo_Fala, waypoint;

	public string[] falas;

	Text chapeuF, loboF;
	int conversa_level;
	bool axisDown;

	void Start(){
		conversa_level = 0;

		chapeuF = chapeu_Fala.GetComponentInChildren<Text> ();
		loboF = lobo_Fala.GetComponentInChildren<Text> ();

		chapeu_Fala.SetActive (false);
		lobo_Fala.SetActive (false);
	}

	void Update () {

		print (conversa_level);

		//lobo = perseguição | chapeu = movimentação | both = conversa
		if (Vo_EnterHouse.entra_sai == 1){ 
			//desabilita o script de movimentação
			jogador.GetComponent<Simple_move>().enabled = false;
			//habilita o script de conversa
			conversa.GetComponent<Conversa_1>().enabled = true;
		}

		if (Vo_EnterHouse.entra_sai == 2) {
			//habilita o script de movimentação
			jogador.GetComponent<Simple_move> ().enabled = true;
			//hablita o caminho de volta
			volta_way.SetActive (true);

			StartCoroutine (Fuga_start ());
		}

		if (Input.GetAxisRaw ("Interagir") > 0){

			if (axisDown == false) {

				if (conversa_level == 0)
					conversa_level++;

				else if (conversa_level == 1)
					Conversas (true);
				
				else if (conversa_level == 2)
					Conversas (false);
				
				else if (conversa_level == 3)
					Conversas (true); 

				else if (conversa_level == 4)
					Conversas (false);
				
				else if (conversa_level == 5)
					Conversas (true);
				
				else if (conversa_level == 6)
					Conversas (false);			
				
				else if (conversa_level == 7) {
					conversa_level++;
				}
				
				axisDown = true;
			}		
		}

		//fim conversa
		if (conversa_level == 8) {
			Destroy(GameObject.Find("Carvas_Conversa"), 10f);
			Vo_EnterHouse.entra_sai = 2;
		}

		if (Input.GetAxisRaw ("Interagir") == 0)
			axisDown = false;
			
	}

	void Conversas (bool isChapeu){
		chapeu_Fala.SetActive (isChapeu);
		lobo_Fala.SetActive (!isChapeu);
		chapeuF.text = falas[conversa_level - 1]; 
		loboF.text = falas[conversa_level - 1]; 
		conversa_level++;
	}

	IEnumerator Fuga_start(){

		yield return new WaitForSeconds (2);

		lobo.transform.position = waypoint.transform.position;
		lobo.transform.localScale = new Vector3 (1.5f, 1.5f, 1);

		yield return new WaitForSeconds (2);
		//habilitar o script de perseguição
		lobo.GetComponent<Lobo_Perseguir> ().enabled = true;

		yield return new WaitForSeconds (2);
		//desabilita a Conversa para melhor perfomance
		conversa.GetComponent<Conversa_1>().enabled = false;		
	}
}
