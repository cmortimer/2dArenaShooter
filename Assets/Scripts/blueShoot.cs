using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class blueShoot : MonoBehaviour {
	public GameObject bullet;
	public GameObject cursor;
	public GameObject player;
	public GameObject bumper;
	public GameObject worldBorder;
	public bool isBumper;
	public float lastPress;
	public float timer;
	
	private ArrayList bullets;
	// Use this for initialization
	void Start () {
		bullets = new ArrayList();
		isBumper = true;
		lastPress = 0.0f;
		timer = 0.0f;
		worldBorder.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;
		//Shooting
		if(Input.GetButtonDown("RB_1")){
			shootBullet();
		}


		if(Input.GetButtonDown("B_1") && isBumper){

			isBumper = false;
			lastPress = timer;
			createBumper();
		}


	}

	void shootBullet(){
		GameObject bulletClone = Instantiate(bullet, player.transform.position, Quaternion.identity) as GameObject;
		bullets.Add(bulletClone);
	}

	void createBumper(){
		GameObject bumperClone = Instantiate(bumper, player.transform.position, Quaternion.identity) as GameObject;

		Vector3 scaleVec = new Vector3(1.4f, 1.4f, 1);
		bumperClone.transform.localScale = scaleVec;

		if((timer - lastPress) > 2.0f)
		{
			bumperClone.transform.position = worldBorder.transform.position;
			isBumper=true;
			timer = 0.0f;
			lastPress = 0.0f;
			
		}

	}
}