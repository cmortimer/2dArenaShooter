using UnityEngine;
using System.Collections;

public class CharacterController2d : MonoBehaviour {
	public GameObject cursor;
	public GameObject bullet;
	public int speed = 6;
	public int cursorSpeed = 50;
	// Use this for initialization
	void Start () {
		cursor.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		getInput();
	}
	
	void getInput(){
		Vector2 newPos = transform.position;
		Vector2 cursorPos = cursor.transform.position;

		//Movement
		if(Input.GetAxis("pad1LAnalogY") > 0){
			newPos.y += speed * Time.deltaTime;
		}
		
		else if(Input.GetAxis("pad1LAnalogY") < 0){
			newPos.y -= speed * Time.deltaTime;
		}
		
		if(Input.GetAxis("pad1LAnalogX") < 0){
			newPos.x -= speed * Time.deltaTime;
		}
		
		else if(Input.GetAxis("pad1LAnalogX") > 0){
			newPos.x += speed * Time.deltaTime;
		}

		//Cursor Position
		if(Input.GetAxis("pad1RAnalogY") > 0){
			cursorPos.y += cursorSpeed * Input.GetAxis("pad1RAnalogY") * Time.deltaTime;
		}
		
		else if(Input.GetAxis("pad1RAnalogY") < 0){
			cursorPos.y += cursorSpeed * Input.GetAxis("pad1RAnalogY") * Time.deltaTime;
		}
		
		if(Input.GetAxis("pad1RAnalogX") < 0){
			cursorPos.x += cursorSpeed * Input.GetAxis("pad1RAnalogX") * Time.deltaTime;
		}
		
		else if(Input.GetAxis("pad1RAnalogX") > 0){
			cursorPos.x += cursorSpeed * Input.GetAxis("pad1RAnalogX") * Time.deltaTime;
		}

		//Teleport
		if(Input.GetButtonDown("pad1L")){
			newPos = cursorPos;
		}



		transform.position = newPos;
		cursor.transform.position = cursorPos;


	}


}
