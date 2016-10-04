using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {

	public Vector3 newLoc = new Vector3(-12.2f, 17.4f, 0);

	private HumanMovement human;
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Human Rig");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
	//	if (Input.GetKeyDown("space"))
		print ("this is a door!");
		//Debug.Log (player);
		collision.gameObject.transform.position = newLoc;

	}
}
