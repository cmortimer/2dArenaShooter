using UnityEngine;
using System.Collections;

public class BumperVars : MonoBehaviour {

	public GameObject bumper;

//	float scale;
	// Use this for initialization
	void Start () {
		bumper.transform.position = transform.position;
		//scale = 20.2f;
		if(gameObject.name.Contains("Clone"))
			Destroy(this.gameObject, 5);
	}

	void OnDestroy(){

	}

	// Update is called once per frame
	void Update () {

	}
	/*
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
	*/
}
