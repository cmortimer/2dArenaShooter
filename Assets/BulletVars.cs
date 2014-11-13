using UnityEngine;
using System.Collections;

public class BulletVars : MonoBehaviour {
	public GameObject player;
	public GameObject cursor;

	private Vector2 newPos;
	public Vector2 startPos;
	public Vector2 endPos;
	public float speed;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
		endPos = cursor.transform.position;
		speed = 8.0f;
	}
	
	// Update is called once per frame
	void Update () {
		MoveBullet();
	}

	void MoveBullet(){
		if(gameObject.name.Contains("Clone")){
			/*Vector2 dist = new Vector2(endPos.x - transform.position.x, endPos.y - transform.position.y);
			newPos = new Vector2(speed * transform.position.x + dist.x, transform.position.y + dist.y);
			transform.position = newPos;*/

		//	float angle = Vector2.Angle(startPos, endPos);
			newPos = transform.position;
			Vector2 current = endPos - startPos;
			if(current.x == 0 && current.y == 0)
			{
				current.x = .01f;
				current.y = .01f;
			}
			current.Normalize();
			current *= speed;
			newPos.x += current.x * Time.deltaTime;	
			newPos.y += current.y * Time.deltaTime;
			transform.position = newPos;
		}
	}
}
