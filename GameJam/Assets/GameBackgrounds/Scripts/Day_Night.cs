using UnityEngine;
using System.Collections;

public class Day_Night : MonoBehaviour {
	static public bool isday = false;
	static public bool isnight = true;
	public float timer = 0.0f;
	static public float nightNum = 1;
	// Use this for initialization
	void Start () {
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Application.loadedLevelName == "Earth_World" || Application.loadedLevelName == "Water_World" || Application.loadedLevelName == "Thunder_World") {
			timer = 0.0f;		
		}

		
		if (isnight && timer > 10.0f) {
			Application.LoadLevel("Main_Tower_Day");
			isday = true;
			isnight = false;
			print (isnight);
			print (isday);
		}
		else if(!isnight && timer > 30.0f){
			Application.LoadLevel("Main_Tower_Night");
			nightNum += 1.0f;
			print(nightNum);
			isnight = true;
			isday = false;
			print (isnight);
			print (isday);
		}

			timer += Time.deltaTime;
	}
}


//-0.14, -0.11
