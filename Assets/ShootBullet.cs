using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
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
		if(Input.GetButtonDown("pad1R")){
			shootBullet();
		}
	}
	
	void shootBullet(){
		GameObject bulletClone = Instantiate(bullet, player.transform.position, player.transform.rotation) as GameObject;

		bullets.Add(bulletClone);
	}
}
