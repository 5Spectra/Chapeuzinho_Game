using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTime_Combat : MonoBehaviour {

	bool axisDown;

	void Start () {

	}

	void Update () {
		if (Input.GetAxisRaw ("QuickTime") > 0)//positivo
		if (axisDown == false){
			axisDown = true;
		}

		if (Input.GetAxisRaw ("QuickTime") < 0)//negativo
		if (axisDown == false){
			axisDown = true;
		}

		if (Input.GetAxisRaw ("QuickTime") == 0)
			axisDown = false;
	}
}
