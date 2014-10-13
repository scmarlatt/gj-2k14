using UnityEngine;
using System.Collections;

public class downladder : MonoBehaviour {
	public GameObject sunman;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (sunman.transform.position.x > -6 && sunman.transform.position.x < 6 && sunman.transform.position.y < 0) {

			if(Input.GetKeyDown("down"))
			{
				print ("IAMLORDE");
				Application.LoadLevel("Main_Tower");
			}
		}
	}
}
