using UnityEngine;
using System.Collections;

public class sunmanController : MonoBehaviour {

	public float maxY = 5f;
	public float maxSpeed = 10f;
	private bool facingRight = true;
	private int rfs = 0;
	public GameObject currentbeam;
	public GameObject lightbeam;

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

		if (Input.GetKeyDown ("w")) {
			rigidbody.velocity = new Vector3 (rigidbody.velocity.x, maxY, 0);
		}
		if (rigidbody.velocity.y > 0.05) {
			rfs = 1;		
		}
		else if(rigidbody.velocity.y < -0.05){
			rfs = -1;
		}
		else{
			rfs = 0;
		}

		anim.SetInteger ("Aerials", rfs);

		//get the current screen position of the mouse from Input
		Vector3 mousePos2D = Input.mousePosition;
		
		//The camera's z position sets the how far to push the mouse into 3D
		mousePos2D.z = 0f;
		
		//convert the point from 2D screen space into 3D game world space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

		Vector3 characterPosition = this.transform.position;
		Vector3 directionFromPlayerToMouse = (mousePos3D - characterPosition).normalized;

		if(Input.GetKey(KeyCode.Mouse0)){
			currentbeam = Instantiate (lightbeam) as GameObject;
			currentbeam.transform.position = transform.position;
			currentbeam.rigidbody.velocity += new Vector3 (50 * directionFromPlayerToMouse.x, 50 * directionFromPlayerToMouse.y, 0);
		}

	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	/*
	void OnCollisionEnter(Collider col){
		if (col.gameObject.layer == 9) {
			rfs = 0;
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, 0,0);		
		}
	}
	*/
}
