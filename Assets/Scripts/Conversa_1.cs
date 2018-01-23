using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversa_1 : MonoBehaviour {

	public GameObject jogador, lobo, conversa, volta_way;
	
	void Update () {
		
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


		//fim da conversa
		if (Input.GetKeyDown (KeyCode.J))
		Vo_EnterHouse.entra_sai = 2;
	}
}
