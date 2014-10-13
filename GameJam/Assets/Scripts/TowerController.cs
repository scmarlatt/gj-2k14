using UnityEngine;
using System.Collections;

public enum attackType {LIGHT, WATER, LIGHTNING, EARTH};

public class TowerController : MonoBehaviour {
	private attackType currentAttack;


	// Use this for initialization
	void Start () {
		currentAttack = attackType.LIGHT;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Player chooses their weapon type
		if(Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0)){
			currentAttack = attackType.LIGHT;
		} else if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)){
			currentAttack = attackType.WATER;
		} else if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)){
			currentAttack = attackType.LIGHTNING;
		} else if(Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)){
			currentAttack = attackType.EARTH;
		}

	}

	void FixedUpdate(){



	}
}
