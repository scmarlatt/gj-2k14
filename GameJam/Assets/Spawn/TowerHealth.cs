using UnityEngine;
using System.Collections;

public class TowerHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GUIText gt = this.GetComponent<GUIText> ();
		gt.text = "Tower Health: " + Stats.ps.health;
	}
}
