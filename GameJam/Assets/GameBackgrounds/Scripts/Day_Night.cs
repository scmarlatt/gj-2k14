using UnityEngine;
using System.Collections;

public class Day_Night : MonoBehaviour {
	static public bool isday = false;
	static public bool isnight = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if (transform.localEulerAngles.y > 330 && transform.localEulerAngles.y < 360) {
			isday = true;
			isnight = false;
			transform.Rotate (3 * Time.deltaTime, 0, 0);
			//print ("itsDay");
		} else {
			isday = false;
			isnight = true;
			transform.Rotate (6 * Time.deltaTime, 0, 0);
			//print ("itsNight");
		}
		
	}
}


//-0.14, -0.11
