using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void OnCollisionStay2D (Collision2D collision)
	{
		Destroy (this.gameObject);
		print ("WOW");

	}
}
