using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTiggerEnter(Collider other){
		Debug.Log ("What?");
		disappear p = other.GetComponent<disappear>();
		if (p != null) p.TakeDamage();
		Destroy(gameObject);

	
	}
}
