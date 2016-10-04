using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collectable : MonoBehaviour {

	public string collectedItem;
	public bool collected;
	public Image uiSpriteReg;
	public Sprite uiSpriteCollected;

	// Use this for initialization
	void Start () {
		collected = false;
		//collectedItem = this.gameObject.name;
		//uiSpriteReg = GameObject.Find ("RoseUI");
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnCollisionStay2D (Collision2D collision)
	{
		//collectedItem = ;
		collected = true;
		if (collected == true) {
			uiSpriteReg.sprite = uiSpriteCollected;
		}
		Destroy (this.gameObject);

	}
}
