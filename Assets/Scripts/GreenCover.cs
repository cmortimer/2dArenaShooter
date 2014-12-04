using UnityEngine;
using System.Collections;

public class GreenCover : MonoBehaviour {

	public GameObject banner;
	public StartScreen greenCover;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		positionCover();
	}
	
	void positionCover()
	{
		if(greenCover.greenReady)
		{
			transform.position = new Vector3(3.71f,-3.93f,0.0f);
			banner.transform.position = new Vector3(30,0,0);
		}
		else
		{
			transform.position = new Vector3(30.0f,0.0f,0.0f);
			banner.transform.position = new Vector3(3.68f,-3.93f,0.0f);
		}
	}
}
