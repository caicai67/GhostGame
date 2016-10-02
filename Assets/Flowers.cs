using UnityEngine;
using System.Collections;

public class Flowers : MonoBehaviour {

//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
	 
	void OnCollisionEnter (Collision collision)
	{
	if(other.gameObject.tag == "Player")

			// do something 
			print("meow");
	
//		else if (other.gameObject.tag == "bullet")
//		{
//			// do something else    
//			// for example decrease health
//		}
//		else if (other.gameObject.tag == "coin")
//		{
//			// do something else    
//			// increment number of coins
//		}
		// and so on .....

	}
}
