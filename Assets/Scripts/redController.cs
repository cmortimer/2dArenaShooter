using UnityEngine;
using System.Collections;

public class redController : MonoBehaviour {
	public GameObject cursor;
	public GameObject bullet;
	public int speed = 6;
	public int cursorSpeed = 50;
	public Vector2 startPos;
	// Use this for initialization
	void Start () {
		cursor.transform.position = transform.position;
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		getInput();
	}
	
	void getInput(){
		Vector2 newPos = transform.position;
		Vector2 cursorPos = cursor.transform.position;
		
		//Movement
		if(Input.GetAxis("L_YAxis_2") > 0){
			newPos.y += speed * Time.deltaTime;
		}
		
		else if(Input.GetAxis("L_YAxis_2") < 0){
			newPos.y -= speed * Time.deltaTime;
		}
		
		if(Input.GetAxis("L_XAxis_2") < 0){
			newPos.x -= speed * Time.deltaTime;
		}
		
		else if(Input.GetAxis("L_XAxis_2") > 0){
			newPos.x += speed * Time.deltaTime;
		}
		
		//Cursor Position
		if(Input.GetAxis("R_YAxis_2") > 0){
			cursorPos.y += cursorSpeed * Input.GetAxis("R_YAxis_2") * Time.deltaTime * .2f;
		}
		
		else if(Input.GetAxis("R_YAxis_2") < 0){
			cursorPos.y += cursorSpeed * Input.GetAxis("R_YAxis_2") * Time.deltaTime * .2f;
		}
		
		if(Input.GetAxis("R_XAxis_2") < 0){
			cursorPos.x += cursorSpeed * Input.GetAxis("R_XAxis_2") * Time.deltaTime * .2f;
		}
		
		else if(Input.GetAxis("R_XAxis_2") > 0){
			cursorPos.x += cursorSpeed * Input.GetAxis("R_XAxis_2") * Time.deltaTime * .2f;
		}
		
		//Teleport
		if(Input.GetButtonDown("LB_2")){
			newPos = cursorPos;
		}
		
		
		
		transform.position = newPos;
		cursor.transform.position = cursorPos;
		
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name.Contains ("Bullet") && !other.name.Contains("redBullet")) {
			transform.position = startPos;
		}
	}
}
