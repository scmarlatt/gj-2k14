using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum attackType {LIGHT, WATER, LIGHTNING, EARTH};

public class TowerController : MonoBehaviour {
	private attackType currentAttack;
	private Vector3 attackOriginPoint;
	public GameObject lightningPrefab;
	public GameObject earthProjectilePrefab;
	public GameObject waterProjectilePrefab;

	private List<GameObject> projectileList;

	// Use this for initialization
	void Start () {
		currentAttack = attackType.LIGHT;
		attackOriginPoint = new Vector3 (-20.48f, 5.47325f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		bool night = Day_Night.isnight;
		if(night){
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

			//Handle firing
			Vector3 targetPos = CrosshairController.S.curpos;
			Vector3 directionFromPlayerToMouse = (targetPos - attackOriginPoint).normalized;
			//Fire lightning
			GameObject projectileObject = null;

			if(currentAttack == attackType.WATER && Input.GetKey(KeyCode.Mouse0 )){
				projectileObject = Instantiate (waterProjectilePrefab) as GameObject;
				projectileObject.transform.position = attackOriginPoint;
				projectileObject.rigidbody.velocity += new Vector3 (20 * directionFromPlayerToMouse.x, 20 * directionFromPlayerToMouse.y, 0);
			} else if(currentAttack == attackType.LIGHTNING && Input.GetKeyDown (KeyCode.Mouse0)){
				print ("firing lightning @: " + CrosshairController.S.curpos);
				projectileObject = Instantiate(lightningPrefab) as GameObject;
				targetPos.y = 15.0f;
				projectileObject.transform.position = targetPos;
			} else if(currentAttack == attackType.EARTH && Input.GetKeyDown (KeyCode.Mouse0)){
				projectileObject = Instantiate(earthProjectilePrefab) as GameObject;
				targetPos.y = -4.3f;
				projectileObject.transform.position = targetPos;
				print ("Firing earth from: " + targetPos);
				projectileObject.rigidbody.velocity += new Vector3 (0, 20, 0);

			}
		}
		//}

	}

	void FixedUpdate(){



	}
}
