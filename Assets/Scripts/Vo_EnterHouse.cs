using UnityEngine;
using System.Collections;

public class Vo_EnterHouse : MonoBehaviour
{
	public float posX;
	public GameObject e_btn;
	bool perto, axisDown;
	public GameObject cam;

	void Start () {
		e_btn.SetActive(false);
	}

	void Update(){
		if (Input.GetAxisRaw ("Interagir") > 0 && perto)
		{
			cam.transform.position = new Vector3 (posX, cam.transform.position.y, cam.transform.position.z);
		}
	}


	void OnTriggerStay2D(Collider2D coll) {
		e_btn.SetActive(true);
		perto = true;
	}

	void OnTriggerExit2D (Collider2D coll){
		e_btn.SetActive(false);
		perto = false;
	}
}

