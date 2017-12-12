using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

	public float velocidade;
	public float tempoDeVida;
	public GameObject explosaoPrefab;

	// Use this for initialization
	void Start () {

		//Configura o tempo de vida do projetil
		Destroy(gameObject, tempoDeVida);
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector2.up * velocidade * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D c) {

		//Destroi o projetil por colisão
		if(c.gameObject.tag == "Inimigo") {

			Instantiate (explosaoPrefab, transform.position, transform.rotation);
			//tem q destruir primeiro o inimigo depois o projetil
			Destroy (c.gameObject);
			Destroy (gameObject);

		}



	}
}
