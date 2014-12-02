using UnityEngine;
using System.Collections;

public class RedCover : MonoBehaviour {

	public GameObject banner;
	public StartScreen redCover;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		positionCover();
	}
	
	void positionCover()
	{
		if(redCover.redReady)
		{
			transform.position = banner.transform.position;
		}
		else
		{
			transform.position = new Vector3(30.0f,0.0f,0.0f);
		}
	}
}
