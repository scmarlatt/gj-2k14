using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	float jumpSpeed = 48f;
	float horiSpeed = 3f;
	float initY;
	public bool flying;
	bool facingRight;
	public float health = 25f;

	// Use this for initialization
	void Start () {
		initY = transform.position.y;
		Flip ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 temp = transform.position;
		temp.x = temp.x - Time.deltaTime * horiSpeed;

		if(flying) {
			float curY = temp.y;
			if(curY <= (initY - 0.5)) {
				rigidbody.AddForce(Vector3.up * jumpSpeed);
//				temp.y = temp.y + Time.deltaTime * 2;
			}
		}

		if (this.health < 0) {
			Destroy(this.gameObject);		
		}

		transform.position = temp;
	}

	void Flip () {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void OnDestroy () {
		Spawn.Remove (this.gameObject);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.layer == 12) {
			print("hi");
			//Stats.ps.health -= 5;
			Destroy(this.gameObject);
		}
		if(col.gameObject.layer == 10 && Day_Night.isnight){
			health -= .25f;
		}
	}
}
