using UnityEngine;
using System.Collections;

public class dayrobotScript : MonoBehaviour {

	public float speed = 8f;
	public float leftAndRightEdge = 2f;
	public GameObject pform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		leftAndRightEdge = (pform.transform.position.x + (pform.transform.localScale.x/2) - 1);
		Vector3 pos = this.transform.position;
		pos.x += speed * Time.deltaTime;
		this.transform.position = pos;
		if (pos.x < (pform.transform.position.x - (pform.transform.localScale.x/2) + 1)) {
			speed = Mathf.Abs (speed);
		} else if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs (speed);
		} 

	}
}
