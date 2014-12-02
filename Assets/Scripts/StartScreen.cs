using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	public bool blueReady;
	public bool redReady;
	public bool greenReady;
	public bool yellowReady;

	// Use this for initialization
	void Start () {
		blueReady = false;
		redReady = false;
		greenReady = false;
		yellowReady = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("A_1"))
		{
			blueReady = !blueReady;
		}
		if(Input.GetButtonDown("A_2"))
		{
			redReady = !redReady;
		}
		if(Input.GetButtonDown("A_3"))
		{
			greenReady = !greenReady;
		}
		if(Input.GetButtonDown("A_4"))
		{
			yellowReady = !yellowReady;
		}

		if(blueReady && redReady && greenReady && yellowReady)
		{
			Application.LoadLevel("Scene1");
		}
	}
}
