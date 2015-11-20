using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameControllerScr : MonoBehaviour {

	public GameObject cookie;
	private GameObject activeSuperCookie;
	public List<Vector3> spawnPoints;
	public GameSettings settings;
	public ScoreController score;


	// Use this for initialization
	void Start () {
		activeSuperCookie = Instantiate(cookie);
		StartCoroutine (ScheduleCookieDestroy());
	
	}

	IEnumerator ScheduleCookieDestroy () {
		yield return new WaitForSeconds (settings.cookieTimeLimit);
		Destroy (activeSuperCookie);
		StartCoroutine (ScheduleCookieCreate ());
		
	}

	IEnumerator ScheduleCookieCreate () {
		yield return new WaitForSeconds (settings.cookieSpawnTime);
		activeSuperCookie = Instantiate(cookie);
		activeSuperCookie.transform.position = settings.cookieSpawnPoints[Random.Range (0, settings.cookieSpawnPoints.Count)];
		activeSuperCookie.GetComponent<Cookie>().touched += HandleSuperCookieTouched;
		 StartCoroutine (ScheduleCookieDestroy());
	}

	void HandleSuperCookieTouched(){
		score.SuperCookieTouched();
	}
	 
	// Update is called once per frame
	void Update () {


	}
}
