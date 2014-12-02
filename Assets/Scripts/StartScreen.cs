using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	public bool blueReady;
	public bool redReady;
	public bool greenReady;
	public bool yellowReady;
	private bool loadedPlayers;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
		blueReady = false;
		redReady = false;
		greenReady = false;
		yellowReady = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.loadedLevelName == "StartScene"){
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

			if(Input.GetButtonDown("Start_1") && blueReady)
				Application.LoadLevel("Scene1");
		}
	}

	void OnLevelWasLoaded(){
		if(!blueReady){
			GameObject bluePlayer = GameObject.Find("blueShip");
			Destroy(bluePlayer.gameObject);
		}
		if(!redReady){
			GameObject redPlayer = GameObject.Find("redShip");
			Destroy(redPlayer.gameObject);
		}
		if(!greenReady){
			GameObject greenPlayer = GameObject.Find("greenShip");
			Destroy(greenPlayer.gameObject);
		}
		if(!yellowReady){
			GameObject yellowPlayer = GameObject.Find("yellowShip");
			Destroy(yellowPlayer.gameObject);
		}
		loadedPlayers = true;

	}
}
