using UnityEngine;
using System.Collections;

public class ElementScripts : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GUIText gt = this.GetComponent<GUIText> ();

		if (TowerController.usingEarth)
			gt.text = "Element: Earth";
		else if(TowerController.usingLightning)
			gt.text = "Element: Lightning";
		else if(TowerController.usingWater)
			gt.text = "Element: Water";
	}
}
