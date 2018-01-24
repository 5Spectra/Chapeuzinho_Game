using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversa_1 : MonoBehaviour {

	public GameObject jogador, lobo, conversa, volta_way;
	public GameObject chapeu_Fala, lobo_Fala;

	public string[] falas;

	Text chapeuF, loboF;
	int conversa_level;

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
			//habilitar o script de perseguição
			lobo.GetComponent<Lobo_Perseguir> ().enabled = true;
			//hablita o caminho de volta
			volta_way.SetActive (true);
			//desabilita a Conversa para melhor perfoma
			conversa.GetComponent<Conversa_1>().enabled = false;
		}

		if (Input.GetKeyDown(KeyCode.E)) {
			if (conversa_level == 0)
				conversa_level++;
		
			else if (conversa_level == 1){
				chapeu_Fala.SetActive (true);
				chapeuF.text = falas[0]; 
				conversa_level++;
			}

			else if (conversa_level == 2){
				chapeu_Fala.SetActive (false);
				lobo_Fala.SetActive (true);
				loboF.text = falas[1]; 
				conversa_level++;
			}

			else if (conversa_level == 3){
				chapeu_Fala.SetActive (true);
				lobo_Fala.SetActive (false);
				chapeuF.text = falas[2]; 
				conversa_level++;
			}

			else if (conversa_level == 4){
				chapeu_Fala.SetActive (false);
				lobo_Fala.SetActive (true);
				loboF.text = falas[3]; 
				conversa_level++;
			}

			else if (conversa_level == 5){
				chapeu_Fala.SetActive (true);
				lobo_Fala.SetActive (false);
				chapeuF.text = falas[4]; 
				conversa_level++;
			}

			else if (conversa_level == 6){
				chapeu_Fala.SetActive (false);
				lobo_Fala.SetActive (true);
				loboF.text = falas[5]; 
				conversa_level++;
			}	
		
			//fim da conversa
			else if (conversa_level == 7) {
				Destroy(GameObject.Find("Carvas_Conversa"), 10f);
				Vo_EnterHouse.entra_sai = 2;
			}
		
		}
			
	}
}
