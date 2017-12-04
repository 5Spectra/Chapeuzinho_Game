using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle_test : MonoBehaviour {

	KeyCode[] keys = { KeyCode.JoystickButton0, KeyCode.JoystickButton1, KeyCode.JoystickButton2,KeyCode.JoystickButton3, KeyCode.JoystickButton4,
		KeyCode.JoystickButton5, KeyCode.JoystickButton6, KeyCode.JoystickButton7, KeyCode.JoystickButton8, KeyCode.JoystickButton9, KeyCode.JoystickButton10,
		KeyCode.JoystickButton11, KeyCode.JoystickButton12, KeyCode.JoystickButton13,KeyCode.JoystickButton14,KeyCode.JoystickButton15,KeyCode.JoystickButton16,
		KeyCode.JoystickButton17,KeyCode.JoystickButton18,KeyCode.JoystickButton19};
		
	void FixedUpdate () {
		for (int i = 0; i < keys.Length; i++) {
			if (Input.GetKeyDown(keys[i]))
			print ("joystick: " + i);
		}
	}
}
