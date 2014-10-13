using UnityEngine;
using System.Collections;

public class sunmanController : MonoBehaviour {

	public float maxY = 5f;
	public float maxSpeed = 10f;
	private bool facingRight = true;
	private int rfs = 0;

	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float move = Input.GetAxis ("Horizontal");
		rigidbody.velocity = new Vector3 (move * maxSpeed, rigidbody.velocity.y, 0);

		anim.SetFloat ("Speed", Mathf.Abs (move));
		if (move > 0 && !facingRight) {
			Flip ();
		}
		else if(move < 0 && facingRight){
			Flip ();
		}

		if (Input.GetKeyDown ("z")) {
			rigidbody.velocity = new Vector3 (rigidbody.velocity.x, maxY, 0);
		}
		if (rigidbody.velocity.y > 0) {
			rfs = 1;		
		}
		else if(rigidbody.velocity.y == 0){
			rfs = 0;
		}
		else if(rigidbody.velocity.y < 0){
			rfs = -1;
		}


		anim.SetInteger ("Aerials", rfs);

	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void OnCollisionEnter(Collider col){
		if (col.gameObject.layer == 9) {
			rfs = 0;
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, 0,0);		
		}
	}
}
