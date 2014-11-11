using UnityEngine;
using System.Collections;

public class VerticalWrap : MonoBehaviour {
	public GameObject oppositeBorder;
	public Vector2 newPos;

	void Start(){
		newPos = new Vector2(0, oppositeBorder.transform.position.y);
		if(oppositeBorder.gameObject.name == "worldBorderD")
			newPos.y += .5f;
		else
			newPos.y -= .5f;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name == "bluePlayer" || other.gameObject.name == "blueCursor")
		{
			newPos.x = other.transform.position.x;
			other.transform.position = newPos;
		}
		if(other.gameObject.name.Contains("blueBullet"))
		{
			Destroy(other.gameObject);
		}
		
	}
}
