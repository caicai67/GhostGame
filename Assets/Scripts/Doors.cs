using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {

	public Vector3 newLoc = new Vector3(-12.2f, 17.4f, 0);

	private HumanMovement human;
	private GameObject player;
	private bool keydown;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Human Rig");
		keydown = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			keydown = true;
		} else   {
			keydown = false;

		}
		print (keydown);
	
	}

	void OnCollisionStay2D (Collision2D collision)
	{
		if (keydown == true && collision.collider.tag == "Human") {
			print ("this is a door!");
			//Debug.Log (player);

			newLoc = getaRoom ();

			collision.gameObject.transform.position = newLoc;
		}
	}

	Vector3 getaRoom() {
		GameObject house = GameObject.Find ("House");
		int numChilds = house.transform.childCount;
		int roomNdx = Random.Range (0, numChilds);
		return house.transform.GetChild (roomNdx).position;
	}


}
