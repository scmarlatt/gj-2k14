using UnityEngine;
using System.Collections;

public class LightningController : ProjectileObject {
	private int timer;

	// Use this for initialization
	void Start () {
		timer = 35;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer--;
		if(timer <= 0){
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
				AI ai = other.GetComponent<AI> ();
				if (ai) {
						ai.TakeDamage (attackType.LIGHTNING);
				}
		}
}
