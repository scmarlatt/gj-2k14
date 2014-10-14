using UnityEngine;
using System.Collections;

public class NightInstructionsScript : MonoBehaviour {

	void OnGUI() {
		
		GUI.Label (new Rect (Screen.width / 2 - 75, Screen.height * 0.1f - 20, 170, 90), "NIGHT INSTRUCTIONS");

		GUI.Label (new Rect (Screen.width / 2 - 70, Screen.height * 0.1f + 5, 140, 90), "THE HUNTED");
		
		GUI.Label (new Rect (Screen.width / 2 - 300, Screen.height * 0.1f + 60, 600, 240), "During the nightime, Sunman is significantly weaker." +
						"You must take refuge in your tower and defend yourself using the elemental powers of the enemies you have slain.\n\n" +
						"Press 1 to select the Water weapon, 2 for Lightning, and 3 for Earth. Left click to fire the weapon.\n\n" +
						"Enemies have elemental weaknesses: Water is strong against Earth, etc.\n\n" +
						"Defend yourself until the sun rises again!" +
						"If enemies reach your tower, it takes damage. When the tower has 0 health, you lose!");
		
		if (GUI.Button (new Rect (Screen.width/2 - 50, Screen.height/2 + 160, 80, 20), "Back")) {
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
