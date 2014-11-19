using UnityEngine;
using System.Collections;

public class yellowShoot : MonoBehaviour {
	public GameObject bullet;
	public GameObject cursor;
	public GameObject player;
	public GameObject bumper;
	
	private ArrayList bullets;
	// Use this for initialization
	void Start () {
		bullets = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//Shooting
		if(Input.GetButtonDown("RB_4")){
			shootBullet();
		}
		if(Input.GetButtonDown("B_4")){
			createBumper();
		}
	}
	
	void shootBullet(){
		GameObject bulletClone = Instantiate (bullet, player.transform.position, Quaternion.identity) as GameObject;

		bullets.Add(bulletClone);
	}
	void createBumper(){
		GameObject bumperClone = Instantiate(bumper, player.transform.position, Quaternion.identity) as GameObject;
	}
}
