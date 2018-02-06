using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class QuickTime_Combat : MonoBehaviour {

	bool axisDown, esperando;

	public GameObject Lenhador, Lobo, c_ataque, c_defesa;
	public Animator animLenhador, animLobo;

	public int vida_Lenhador, vida_Lobo;
	
	public int phase = 0; //0 = parado || 1 = Heroi Atacando || 2 = Lobo Atacando 

	bool presNeg, presPos, presPermision;

	public Image ShowVidaLobo, ShowVidaLenhador;
	
	void Start () {
		
		Camera.main.orthographicSize = 2.85f;

		Lenhador.SetActive(true); 
		Lobo.SetActive(true);
	}

	void Update () {

		//camera
		Vector3 centerPos = Vector3.Lerp(Lenhador.transform.position, Lobo.transform.position, 0.5f);
		Camera.main.transform.position = new Vector3 (centerPos.x, -2f,-10);


		if (axisDown== false && presPermision == true){
			
			//positivo - Ataque
			if (Input.GetAxisRaw ("QuickTime") > 0 ){
				axisDown = true;
				presNeg = false;
				presPos = true;
				presPermision = false;
			}

			//negativo - Defesa
			if (Input.GetAxisRaw ("QuickTime") < 0){
				axisDown = true;
				presNeg = true;
				presPos = false;
				presPermision = false;
			}
		}
			
		if (Input.GetAxisRaw ("QuickTime") == 0){
			axisDown = false;
		}
	
		//QTE - Quick Time Event
			if (vida_Lobo == 0) {				
				StartCoroutine (Ending_Fight (animLobo, "Vitoria"));
			}
			else if (vida_Lenhador == 0) {
				StartCoroutine (Ending_Fight (animLenhador, "Death"));
			}

			else if(esperando == false)
				StartCoroutine(Turnos());

		print("N " + presNeg);	print("P " + presPos);
	}


	void Ataque(){
		
	}

	void Defesa(){
		
	}

	IEnumerator Turnos(){
		esperando = true;
		yield return new WaitForSeconds (2f); //dando um tempo

		if (phase == 1){//heroi turn -------------------------------------------- 1

			animLenhador.SetInteger("Walk", 1);
			animLenhador.SetInteger("Estado", 4);

			yield return new WaitForSeconds (2f); //tempo para andar
			animLenhador.SetInteger("Estado", 0);
			//c_ataque.SetActive(true);
			presPermision = true;
			print ("Click");

			yield return new WaitForSeconds (2f); //verificação e tempo do QTE

			if (presPos == true){
				animLenhador.SetInteger("Estado", Random.Range (1,3));
				vida_Lobo -= 1;
				animLobo.SetInteger("Estado", 5);
				Perder_Vida(ShowVidaLobo, vida_Lobo, 6);
			}
			Reset_Press();

			yield return new WaitForSeconds (2f); //tempo animação de ataque
			animLenhador.SetInteger("Estado", 0);
			animLobo.SetInteger("Estado", 0);

			yield return new WaitForSeconds (.5f); //tempo do reset das anim
			//c_ataque.SetActive(false);
			animLenhador.SetInteger("Walk", 0);
			animLenhador.SetInteger("Estado", 4);
		}

		if (phase == 2){//vilao turn -------------------------------------------- 2

			animLobo.SetInteger("Walk", 1);
			animLobo.SetInteger("Estado", 4);

			yield return new WaitForSeconds (2f); //tempo para andar
			animLobo.SetInteger("Estado", 0);
			//c_defesa.SetActive(true);
			presPermision = true;
			print ("Click");

			yield return new WaitForSeconds (2f); //verificação e tempo do QTE
			animLobo.SetInteger("Estado", 1);

			if (presNeg == false){
				vida_Lenhador -= 1;
				animLenhador.SetInteger("Estado", 5);
				Perder_Vida(ShowVidaLenhador, vida_Lenhador, 3);
			}
			else {
				animLenhador.SetInteger("Estado", 3);
			}

			Reset_Press();

			yield return new WaitForSeconds (2f); //tempo animação de ataque
			animLenhador.SetInteger("Estado", 0);
			animLobo.SetInteger("Estado", 0);

			yield return new WaitForSeconds (.5f); //tempo do reset das anim
			//c_defesa.SetActive(false);
			animLobo.SetInteger("Walk", 0);
			animLobo.SetInteger("Estado", 4);
		}

		yield return new WaitForSeconds (2f); // tempo para voltar
		animLenhador.SetInteger("Estado", 0);
		animLobo.SetInteger("Estado", 0);
		esperando = false;
		if (phase == 2) phase = 0;
		phase++;
	}

	IEnumerator Ending_Fight(Animator anima, string cena){
		print ("end");

		esperando = true;

		anima.SetInteger("Estado", 9);

		yield return new WaitForSeconds (4f);

		UnityEngine.SceneManagement.SceneManager.LoadScene(cena);

	}

	void Reset_Press(){
		presPermision = false;
		presNeg = false;
		presPos = false;
	}
	
	void Perder_Vida(Image ShowVida,float vida, int startVida){
		ShowVida.fillAmount = vida / startVida;
	}
	
}
