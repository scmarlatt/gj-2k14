using UnityEngine;
using System.Collections;

public class lightbeamScript : MonoBehaviour {

	public float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (timer > .5) {
			Destroy(this.gameObject);		
		}

		   timer += Time.deltaTime;
	}
}
