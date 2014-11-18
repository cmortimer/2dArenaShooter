using UnityEngine;
using System.Collections;

public class blueShoot : MonoBehaviour {
	public GameObject bullet;
	public GameObject cursor;
	public GameObject player;
	
	private ArrayList bullets;
	// Use this for initialization
	void Start () {
		bullets = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//Shooting
		if(Input.GetButtonDown("RB_1")){
			shootBullet();
		}
	}
	
	void shootBullet(){
		GameObject bulletClone = Instantiate(bullet, player.transform.position, Quaternion.identity) as GameObject;
		
		bullets.Add(bulletClone);
	}
}