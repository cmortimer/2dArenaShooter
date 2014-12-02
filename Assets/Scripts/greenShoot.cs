using UnityEngine;
using System.Collections;

public class greenShoot : MonoBehaviour {
	public GameObject bullet;
	public GameObject cursor;
	public GameObject player;
	public GameObject bumper;

	public float lastPress;
	public float timer;
	
	private ArrayList bullets;
	private ArrayList bumpers;
	// Use this for initialization
	void Start () {
		bullets = new ArrayList();
		bumpers = new ArrayList();

		lastPress = 0.0f;
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;
		//Shooting
		if(Input.GetButtonDown("RB_3")){
			shootBullet();
		}

		if(Input.GetButtonDown("B_3") && ((timer - lastPress) > 1.0f)){
			
			lastPress = timer;
			createBumper();
		}
	}
	
	void shootBullet(){
		GameObject bulletClone = Instantiate (bullet, player.transform.position, Quaternion.identity) as GameObject;

		bullets.Add(bulletClone);
	}
	void createBumper(){
		if (bumpers.Count <= 5) {
			GameObject bumperClone = Instantiate(bumper, player.transform.position, Quaternion.identity) as GameObject;
			
			Vector3 scaleVec = new Vector3(1.4f, 1.4f, 1);
			bumperClone.transform.localScale = scaleVec;
			
			bumpers.Add(bumperClone);
		}
	}

}
