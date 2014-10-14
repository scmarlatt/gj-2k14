using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	
	public enum Type { Water, Lightning, Earth };
	
	float jumpSpeed = 48f;
	public float horiSpeed = 3f;
	float initY;
	public Type type;
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
			TakeDamage(convert(col.gameObject.name));
			Stats.ps.health -= 5;
			if(health <= 0) {
				Destroy(this.gameObject);
			}
		}
		
		//Got hit with a projectile
		/*
		if(col.gameObject.layer == 10 && Day_Night.isnight){
			if(col.GetComponent<WaterProjectileController>()){
				health -= .25f;
				//Add slow in later
			}
		*/
		
		
	}
	
	public void TakeDamage(attackType at){
		float mod = 1f;
		if(at == attackType.EARTH){
			if(type == Type.Lightning) {
				mod = mod * 1.2f;
			} else if (type == Type.Water) {
				mod = mod * 0.8f;
			}
			health -= mod * 5.0f;
		} else if (at == attackType.LIGHTNING){
			if(type == Type.Earth) {
				mod = mod * 0.8f;
			} else if (type == Type.Water) {
				mod = mod * 1.2f;
			}
			health -= mod * 8.0f;
		} else if (at == attackType.WATER){
			if(type == Type.Lightning) {
				mod = mod * 0.8f;
			} else if (type == Type.Earth) {
				mod = mod * 1.2f;
			}
			health -= mod * .25f;
		} else {
			health -= mod * 3.0f;
		}
	}
	
	attackType convert(string name) {
		if (name == "WaterProjectilePrefab") {
			return attackType.WATER;
		} else if (name == "LightningProjectilePrefab") {
			return attackType.LIGHTNING;
		} else if (name == "EarthProjectilePrefab") {
			return attackType.EARTH;
		} else {
			return attackType.LIGHT;
		}
	}
}