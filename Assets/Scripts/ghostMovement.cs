using UnityEngine;
using System.Collections;

public class ghostMovement : MonoBehaviour {

	public float speed = 10f;

	private Rigidbody2D body;
	private float horz;
	private float vert;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		vert = Input.GetAxis ("ws");
		horz = Input.GetAxis ("ad");
		Debug.Log (" horz: " + horz);
		body.AddForce (Vector2.right * horz * speed);
		body.AddForce (Vector2.up * vert * speed);
	}
}
