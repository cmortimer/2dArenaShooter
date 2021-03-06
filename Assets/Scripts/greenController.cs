﻿using UnityEngine;
using System.Collections;

public class greenController : MonoBehaviour {
	public GameObject cursor;
	public GameObject bullet;
	public int speed = 6;
	public int cursorSpeed = 50;
	public Vector2 startPos;

	public Menu menu;
	// Use this for initialization
	void Start () {
		cursor.transform.position = transform.position;
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		getInput();
		followCursor();
	}
	
	void getInput(){
		Vector2 newPos = transform.position;
		Vector2 cursorPos = cursor.transform.position;

		if (!menu.menuOpen) {
			//Movement
			if(Input.GetAxis("L_YAxis_3") > 0){
				newPos.y += speed * Time.deltaTime;
			}
			
			else if(Input.GetAxis("L_YAxis_3") < 0){
				newPos.y -= speed * Time.deltaTime;
			}
			
			if(Input.GetAxis("L_XAxis_3") < 0){
				newPos.x -= speed * Time.deltaTime;
			}
			
			else if(Input.GetAxis("L_XAxis_3") > 0){
				newPos.x += speed * Time.deltaTime;
			}
			
			//Cursor Position
			if(Input.GetAxis("R_YAxis_3") > 0){
				cursorPos.y += cursorSpeed * Input.GetAxis("R_YAxis_3") * Time.deltaTime * .2f;
			}
			
			else if(Input.GetAxis("R_YAxis_3") < 0){
				cursorPos.y += cursorSpeed * Input.GetAxis("R_YAxis_3") * Time.deltaTime * .2f;
			}
			
			if(Input.GetAxis("R_XAxis_3") < 0){
				cursorPos.x += cursorSpeed * Input.GetAxis("R_XAxis_3") * Time.deltaTime * .2f;
			}
			
			else if(Input.GetAxis("R_XAxis_3") > 0){
				cursorPos.x += cursorSpeed * Input.GetAxis("R_XAxis_3") * Time.deltaTime * .2f;
			}
			
			//Teleport
			if(Input.GetButtonDown("LB_3")){
				newPos = cursorPos;
			}

			transform.position = newPos;
			cursor.transform.position = cursorPos;
		}
	}

	void followCursor()
	{
		
		Vector3 vectorToTarget = cursor.transform.position - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, 1000);
		
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.name.Contains ("Bullet") && !other.name.Contains("greenBullet")) {
			//transform.position = startPos;
		}
	}
}
