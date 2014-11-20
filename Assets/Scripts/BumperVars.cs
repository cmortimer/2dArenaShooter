using UnityEngine;
using System.Collections;

public class BumperVars : MonoBehaviour {

	public GameObject bumper;
	public int count;

//	float scale;
	// Use this for initialization
	void Start () {
		bumper.transform.position = transform.position;
		count = 0;
		//scale = 20.2f;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.name.Contains ("Bullet")) {
			Destroy(other.gameObject); //Should destroy the bullet upon contact
			count++;
			if(count >= 5) //Bumper dies after 5 hits
			{
				count = 0;
				Destroy(this.gameObject);
			}
		}
	}
}
