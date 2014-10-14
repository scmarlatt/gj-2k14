using UnityEngine;
using System.Collections;

//Spawn with ypos of .3

public class EarthProjectileController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y <= -9.0f){
			Destroy(gameObject);
		}
	
	}

	void OnTriggerEnter(Collider other){
		if(other.GetComponent<AI>() && this.rigidbody.velocity.y <= 0.0f){
			other.GetComponent<AI>().TakeDamage(attackType.EARTH);
			Destroy(this.gameObject);
		}
	}
}
