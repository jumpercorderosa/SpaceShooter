﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigosScript : MonoBehaviour {

	public GameObject inimigo;
	public float limiteEsquerdo, limiteDireito;
	public float tempoInicial, tempoFinal;

	IEnumerator Start() {

		//Aguarda para criaçao de um inimigo
		//yield return new WaitForSeconds (Random.Range(0.5f, 1.5f));
		yield return new WaitForSeconds (Random.Range(tempoInicial, tempoFinal));

		//Sorteia a posicao em X para o inimigo
		Vector2 posicao = new Vector2(Random.Range(limiteEsquerdo, limiteDireito), transform.position.y);

		//Instancia o inimigo
		Instantiate(inimigo, posicao, transform.rotation);

		//Looping
		StartCoroutine(Start());

	}
	// Update is called once per frame
	void Update () {
		
	}
}
