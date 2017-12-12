﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour {

	public GameObject projetil;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump")) {

			//transform.position pega a posição da propria arma, e o projetil vai sair da propria nave
			Instantiate (projetil, transform.position, transform.rotation);
		}
	}
}
