using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public Transform playerTransform;
	public float dist;



	// Update is called once per frame
	void Update () {
		NavMeshAgent nm = GetComponent<NavMeshAgent> ();

		dist = Vector3.Distance (playerTransform.position, gameObject.transform.position);
		if (dist < 2f) {
			nm.Resume ();
			nm.SetDestination (playerTransform.position);
		} else {
			nm.Stop ();
		}

	}
}
