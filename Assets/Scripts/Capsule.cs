using UnityEngine;
using System.Collections;
using System;

public class Capsule : MonoBehaviour {

	public Action touched;


	void OnTriggerEnter(Collider other){
		gameObject.SetActive(false);

		if (touched != null)
			touched ();

	}
	// Update is called once per frame

}
