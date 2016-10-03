using UnityEngine;
using System.Collections;

public class Flowers : MonoBehaviour {
	public int flowerValue;
	public int playerScore;

//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
	 
	void OnCollisionStay2D (Collision2D collision)
	{
		//if(collision.gameObject.tag == "player")
		playerScore = playerScore + flowerValue;
		Destroy (this.gameObject);
		print (playerScore);

	}
}
