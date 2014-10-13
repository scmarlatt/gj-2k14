using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {
	public GameObject flyEnemy;
	public GameObject landEnemy;
	public static List<GameObject> allObj;

	void Start () {
		allObj = new List<GameObject> ();
	}
	// Update is called once per frame
	void Update () {
		if(allObj.Count < 10) {
			if(Random.Range(0,9) >= 8) {
				Vector3 temp = transform.position;
				temp.y = temp.y + Random.Range(-1,1);
				if(Random.Range(0,1) == 0) {
					allObj.Add (Instantiate(flyEnemy, temp, Quaternion.identity) as GameObject);
				} else {
					allObj.Add (Instantiate(landEnemy, temp, Quaternion.identity) as GameObject);
				}
			}
		}
	}

	public static void Remove (GameObject enemy) {
		allObj.Remove (enemy);
	}
}
