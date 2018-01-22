using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStick_detection : MonoBehaviour {

	string[] abc;


	void Update(){
		
		abc = Input.GetJoystickNames ();

		for (int i = 0; i < abc.Length - 1; i++)
			
			print ("Está: " + abc [i]);
		}

	}

