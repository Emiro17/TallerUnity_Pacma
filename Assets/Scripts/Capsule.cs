using UnityEngine;
using System.Collections;

public class Capsule : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		gameObject.SetActive(false);
		Debug.Log ("Chocapic");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
