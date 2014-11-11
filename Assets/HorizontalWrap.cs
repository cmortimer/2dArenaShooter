using UnityEngine;
using System.Collections;

public class HorizontalWrap : MonoBehaviour {
	public GameObject oppositeBorder;
	public Vector2 newPos;
	
	void Start(){
		newPos = new Vector2(oppositeBorder.transform.position.x, 0);
		if(oppositeBorder.gameObject.name == "worldBorderL")
			newPos.x += .5f;
		else
			newPos.x -= .5f;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name == "bluePlayer" || other.gameObject.name == "blueCursor")
		{
			newPos.y = other.transform.position.y;
			other.transform.position = newPos;
		}
		if(other.gameObject.name.Contains("blueBullet"))
		{
			Destroy(other.gameObject);
		}
	}
}
