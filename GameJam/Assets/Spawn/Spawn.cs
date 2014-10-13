using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {
	public GameObject Enemy;
	public static List<GameObject> allObj;

	void Start () {
		allObj = new List<GameObject> ();
	}
	// Update is called once per frame
	void Update () {
		if(allObj.Count < 10 && Day_Night.isnight) {
			if(Random.Range(0,100) >= 95) {
				Vector3 temp = transform.position;
				AI type = Enemy.GetComponent<AI> ();
				if(type.flying) {
					temp.y = temp.y + Random.Range(-1,1);
				}
				allObj.Add (Instantiate(Enemy, temp, Quaternion.identity) as GameObject);
			}
		}
	}

	public static void Remove (GameObject enemy) {
		allObj.Remove (enemy);
	}
}
