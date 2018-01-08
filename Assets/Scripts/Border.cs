using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D coll)
	{
		Transform trans = coll.transform;
		float pos_neg = 0.1f;

		if (trans.position.x < 0)
			pos_neg *= -1;

		trans.position = new Vector2 (trans.position.x - pos_neg, trans.position.y);
		print (trans.name);

	}
}
