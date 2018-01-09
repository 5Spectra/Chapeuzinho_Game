using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Selector : MonoBehaviour {

	public RectTransform selector;
	[SerializeField]
	int btn_selecao;

	public Transform menus;
	public Text tetos;

	void Start () {
		selector.localPosition  = new Vector3 ( -230, -20);
		print(menus.childCount);
	}

	void Update () {
	
		if (Input.GetKeyDown (KeyCode.W) && btn_selecao > 0) {
			Verifc (-1);
			selector.localPosition  -= new Vector3 (0, -110);
		}

		if (Input.GetKeyDown (KeyCode.S) && btn_selecao < 2) {
			Verifc (1);
			selector.localPosition  -= new Vector3 (0, 110);
		}

		if (Input.GetKeyDown(KeyCode.Return) ||Input.GetKeyDown (KeyCode.Joystick1Button7)) {
		//if (Input.GetKeyDown (KeyCode.E)) {
			switch (btn_selecao) {
			case 0:
				tetos.text = "a";
				break;
			case 1: 
				tetos.text = "b";
				break;
			case 2: 
				tetos.text = "c";
				break;
			}
		}

	}

	void Verifc(int num){
		btn_selecao += num;
		if (btn_selecao == menus.childCount + 1){ btn_selecao = 0;}
	}
}
