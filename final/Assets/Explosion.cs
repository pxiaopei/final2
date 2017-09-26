﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public GameObject explosionPrefab;

	void OnTriggerEnter(Collider other){
		Destroy (gameObject);

		GameObject explision = (GameObject)Instantiate (explosionPrefab, transform.position,
			                       transform.rotation);
		Destroy (explision, 3.0f);
	
	
	}
}
