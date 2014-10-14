using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	void OnGUI() {
		
		GUI.Label (new Rect (Screen.width / 2 - 50, Screen.height * 0.1f - 20, 100, 90), "SUN HUNTER");

		if (GUI.Button (new Rect (Screen.width/2 - 80, Screen.height/2, 160, 25), "Night Instructions")) {
			Application.LoadLevel ("_Night_Instructions");
		}
		if (GUI.Button (new Rect (Screen.width/2 - 80, Screen.height/2 + 40, 160, 25), "Day Instructions")) {
			Application.LoadLevel ("_Day_Instructions");
		}
		if (GUI.Button (new Rect (Screen.width/2 - 80, Screen.height/2 + 80, 160, 25), "START")) {
			Application.LoadLevel ("_Main_Menu");
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
