using UnityEngine;
using System.Collections;

public class CharacterController2d : MonoBehaviour {
	int speed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		getInput();
	}
	
	void getInput(){
		Vector2 newPos = transform.position;
		Quaternion newRot = transform.rotation;
		if(Input.GetKey("w")){
			newPos.y += speed * Time.deltaTime;
		}
		
		else if(Input.GetKey("s")){
			newPos.y -= speed * Time.deltaTime;
		}
		
		if(Input.GetKey("a")){
			newPos.x -= speed * Time.deltaTime;
		}
		
		else if(Input.GetKey("d")){
			newPos.x += speed * Time.deltaTime;
		}
		transform.position = newPos;
	}
}
