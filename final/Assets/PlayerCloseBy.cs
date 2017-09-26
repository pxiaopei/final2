using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCloseBy : MonoBehaviour {

	public GetKey playerGetKey;
	public GameObject player;

	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		{
			playerGetKey.KeyGot();
		}
	}
}

	//	if (Vector3.Distance(player.transform.position, gameObject.transform.position) < 2f)