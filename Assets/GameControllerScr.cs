using UnityEngine;
using System.Collections;

public class GameControllerScr : MonoBehaviour {

	public GameObject cookie;
	private GameObject activeSuperCookie;

	// Use this for initialization
	void Start () {
		activeSuperCookie = Instantiate(cookie);
		StartCoroutine (ScheduleCookieDestroy());
	
	}

	IEnumerator ScheduleCookieDestroy () {
		yield return new WaitForSeconds (3.0f);
		Destroy (activeSuperCookie);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
