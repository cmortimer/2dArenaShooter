using UnityEngine;
using System.Collections;

public class BulletVars : MonoBehaviour {
	public GameObject player;
	public GameObject cursor;

	private Vector2 newPos;
	public Vector2 endPos;
	// Use this for initialization
	void Start () {
		endPos = cursor.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		MoveBullet();
		if(transform.position.Equals(endPos))
		{
			print("Kill me");
		}
	}

	void MoveBullet(){
		if(gameObject.name.Contains("Clone")){
			Vector2 dist = new Vector2(endPos.x - transform.position.x, endPos.y - transform.position.y);
			dist.Scale(new Vector2(3f, 3f) * Time.deltaTime);
			newPos = new Vector2(transform.position.x + dist.x, transform.position.y + dist.y);
			transform.position = newPos;
		}
	}
}
