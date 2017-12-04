using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_as_child : MonoBehaviour {

	public GameObject m_pPrefab;
	public GameObject inicio;
	GameObject go;

	void Start () {
		
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			spawnar();
		}
	}

	void spawnar(){

		go = Instantiate(m_pPrefab, new Vector3 (0,0,0), Quaternion.identity) as GameObject;	

		go.transform.parent = inicio.transform;
	}
}
