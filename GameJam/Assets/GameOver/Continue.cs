using UnityEngine;
using System.Collections;

public class Continue : MonoBehaviour {

	void OnGUI () {
		GUILayout.BeginArea (new Rect (Screen.width/2 - 60, Screen.height/2 + 40, 200, 200));
		if(GUILayout.Button(new GUIContent ("Continue"))) {
			Application.LoadLevel("Main_Tower_Night");
		}
		GUILayout.EndArea ();
	}
}
