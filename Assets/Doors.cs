using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {

	private HumanMovement human;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
	//	if (Input.GetKeyDown("space"))
		print ("this is a door!");
		Transform.root.FindChild("HumanRig").transform.Translate = new Vector2 (5.6f, .99f);

	}
}
