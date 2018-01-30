using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick_detection : MonoBehaviour {


	public static bool isJoyConnect;

	void Update(){
//		// Detecta todos os controles conectados.
//		string[] abc;
//		abc = Input.GetJoystickNames ();
//		for (int i = 0; i < abc.Length - 1; i++)			
//			print ("Está: " + abc [i]);
//		}

		string[] controle = Input.GetJoystickNames();

		foreach(string con in controle){
			if (con != string.Empty)
				isJoyConnect = true;
			else 
				isJoyConnect = false;
		}
	}
}

