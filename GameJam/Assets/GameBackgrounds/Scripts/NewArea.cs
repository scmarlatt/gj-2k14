using UnityEngine;
using System.Collections;

public class NewArea : MonoBehaviour {

	public enum Location { Water, Lightning, Earth, Base };
	public Location loc;
	
	void OnTriggerEnter(Collider coll) {
		Debug.Log ("yo");
		if(coll.gameObject.name == "sunman") {
			if(loc == Location.Water) {
				Application.LoadLevel ("Water_World");
			} else if (loc == Location.Lightning) {
				Application.LoadLevel ("Thunder_World");
			} else if (loc == Location.Earth) {
				Application.LoadLevel ("Earth_World");
			} else if (loc == Location.Base) {
				Application.LoadLevel ("Main_Tower_Night");
				Day_Night.isnight = true;
				Day_Night.nightNum += 1;
			}
		}
	}
}
