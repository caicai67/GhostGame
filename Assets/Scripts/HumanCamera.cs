using UnityEngine;
using System.Collections;

public class HumanCamera : MonoBehaviour {

	private SpriteRenderer roomR;

	// Use this for initialization
	void Start () {
		roomR = GameObject.Find("House").transform.Find("Bedroom 2").GetComponent<SpriteRenderer>();
	}
	// Update is called once per frame
	void Update () {
		Vector3 roomMin = roomR.bounds.min;
		Vector3 roomMax = roomR.bounds.max;
		Debug.Log ("room min " + roomMin);
		Debug.Log ("room max " + roomMax);
	}
}
