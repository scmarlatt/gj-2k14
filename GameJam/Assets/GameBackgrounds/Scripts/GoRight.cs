using UnityEngine;
using System.Collections;

public class GoRight : MonoBehaviour {
	public GameObject sunman;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (sunman.transform.position.x > 23.5 && sunman.transform.position.y > 2) {

			if(Input.GetKey("d")){
				Application.LoadLevel("Main_Tower");
			}
			}
	}
}
