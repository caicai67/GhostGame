using UnityEngine;
using System.Collections;

public class HumanMovement : MonoBehaviour {

	public float speed = 10f;

	private Rigidbody2D body;
	private float horz;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		horz = Input.GetAxis ("Horizontal");
		body.AddForce (Vector2.right * horz * speed);
	}
}
