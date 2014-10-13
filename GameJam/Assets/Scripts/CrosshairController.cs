using UnityEngine;
using System.Collections;

public class CrosshairController : MonoBehaviour {
	static public CrosshairController S;
	static Vector3 curpos;


	// Use this for initialization
	void Start () {
		S = this;
		curpos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Move the crosshair
		Vector3 mousePos2D = Input.mousePosition;
		
		//Camera's Z pos sets how far to push the mouse into 3d
		mousePos2D.z = -Camera.main.transform.position.z;
		
		//Convert the point from 2d screen space into 3d game world space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);
		
		//Move the x position of this Basket to the x position of the Mouse
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		pos.y = mousePos3D.y;
		this.transform.position = pos;
		curpos = this.transform.position;
	}
}
