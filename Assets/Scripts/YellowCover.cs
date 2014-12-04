using UnityEngine;
using System.Collections;

public class YellowCover : MonoBehaviour {

	public GameObject banner;
	public StartScreen yellowCover;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		positionCover();
	}
	
	void positionCover()
	{
		if(yellowCover.yellowReady)
		{
			transform.position = new Vector3(7.30f,-3.93f,0.0f);
			banner.transform.position = new Vector3(30,0,0);
		}
		else
		{
			transform.position = new Vector3(30.0f,0.0f,0.0f);
			banner.transform.position = new Vector3(7.30f,-3.93f,0.0f);
		}
	}
}
