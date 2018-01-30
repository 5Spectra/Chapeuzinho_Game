using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Selector_old : MonoBehaviour {

	//não foi utilizado

	public RectTransform selector;
	[SerializeField]
	int btn_selecao;

	public Transform menus;
	public Text tetos;

	bool axisDown;

	void Start () {
		selector.localPosition  = new Vector3 ( -230, -20);
	}

	void Update () {

		bool x = Input.GetButtonDown ("Menu JoyStick");
		print (x);

		if (Input.GetKeyDown (KeyCode.W))
			if (axisDown == false && btn_selecao > 0) {
				Verifc (-1);
				selector.localPosition  -= new Vector3 (0, -110);
		}

		if (Input.GetKeyDown (KeyCode.S))
			if (axisDown == false && btn_selecao < 2) {
				Verifc (1);
				selector.localPosition -= new Vector3 (0, 110);
			}

		if (Input.GetKeyDown(KeyCode.Return) || Input.GetAxisRaw ("Interagir") > 0) {
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

		if (Input.GetAxisRaw ("Interagir") == 0)
			axisDown = false;
		

	}

	void Verifc(int num){
		btn_selecao += num;
		if (btn_selecao == menus.childCount + 1){ btn_selecao = 0;}
	}
}
