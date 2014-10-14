using UnityEngine;
using System.Collections;

public class WaterProjectileController : ProjectileObject {
	private float maxXRange;
	private Vector3 attackOriginPoint = new Vector3 (-20.48f, 5.47325f, 0.0f);

	
	// Use this for initialization
	void Start () {
		float maxXPos = 10.0f;
		//Vector3 maxXPos = Stats.S.maxXRange;
		//maxXPos += attackOriginPoint.x;
		float maxXRange = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x >= maxXRange || this.transform.position.x <= -21.0f) {
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		if(!other.GetComponent<ProjectileObject>()){
			AI ai = other.GetComponent<AI>();
			if(ai){
				ai.TakeDamage(attackType.WATER);
			}
			Destroy(this.gameObject);
		}
	}
}
