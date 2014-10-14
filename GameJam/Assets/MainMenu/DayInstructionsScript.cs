using UnityEngine;
using System.Collections;

public class DayInstructionsScript : MonoBehaviour {

	void OnGUI() {
		
		GUI.Label (new Rect (Screen.width / 2 - 80, Screen.height * 0.1f - 20, 140, 90), "DAY INSTRUCTIONS");

		GUI.Label (new Rect (Screen.width / 2 - 60, Screen.height * 0.1f + 5, 140, 90), "THE HUNTER");

		GUI.Label (new Rect (Screen.width / 2 - 300, Screen.height * 0.1f + 60, 600, 240), "During the daytime, Sunman is much stronger " +
			"than the enemies he faces. \n\nAfter leaving your tower, you only have the duration of the day (about 30 seconds) to " +
			"kill as many enemies as possible to upgrade your tower. \n\nYou may leave the main area by either going up, left or right. " +
			"Once inside the new area, use WASD to move and left click to shoot. \n\n" +
			"Clearing a zone of enemies will upgrade the weapon of the element of the level cleared: killing earth enemies will upgrade your earth weapon. \n\n" +
			"Accidentally leaving a zone will cause night to fall again, so be careful where you step!\n\n" +
			"HINT: Pick a zone to go to quickly! You don't want your daylight to run out before you kill enemies and get the upgrade.");

		if (GUI.Button (new Rect (Screen.width/2 - 50, Screen.height/2 + 160, 80, 20), "Back")) {
			Application.LoadLevel ("_Main_Menu");
		}

		//GUI.Box (new Rect (0,Screen.height - 50,100,50), "Bottom-left");



		//GUI.Box (new Rect (Screen.width/2 - 50, Screen.height / 2, 100, 100), "CONTROLS");
		
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
