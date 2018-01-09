using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_doce : MonoBehaviour {


	public Sprite[] imagens_doce;

	void Start () {
		
		int rng = Random.Range (0, imagens_doce.Length);

		SpriteRenderer render = GetComponent<SpriteRenderer>();
		render.sprite = imagens_doce[rng];

	}
}
