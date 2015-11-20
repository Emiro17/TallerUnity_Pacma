using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

	private float totalScore;
	private Text scoreText;
	private GameObject[] capsules;


	// Use this for initialization
	void Start () {
		scoreText = FindObjectOfType (typeof(Text)) as Text;
		capsules = GameObject.FindGameObjectsWithTag ("Capsule");
		foreach (GameObject Capsule in capsules) {
			Capsule.GetComponent<Capsule> ().touched += HandleCapsuleTouched;
		}
	}

	void HandleCapsuleTouched() {
			totalScore += 1;
			

		}

	public void SuperCookieTouched() {
		totalScore += 10;
		
		
	}


	// Update is called once per frame
	void Update () {
		scoreText.text = "SCORE:" +totalScore;
		
	
	}
}
