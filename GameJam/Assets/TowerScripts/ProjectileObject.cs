using UnityEngine;
using System.Collections;

public class ProjectileObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		//don't want to destroy lightning
		if(this.GetComponent<LightningController>()){
			return;
		}

		if (other.gameObject.GetComponent<ProjectileObject>() != null) {
				return;
		} else {
			Destroy (this.gameObject);
		}
	}
}
