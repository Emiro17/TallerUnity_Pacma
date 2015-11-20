using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	public void OpenGame (string name){
		Application.LoadLevel(name);
	}
}
