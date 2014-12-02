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
			transform.position = banner.transform.position;
		}
		else
		{
			transform.position = new Vector3(30.0f,0.0f,0.0f);
		}
	}
}
