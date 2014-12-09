using UnityEngine;
using System.Collections;

public class WinInput : MonoBehaviour {

	public GUIText score;
	public SpriteRenderer winScreen;
	public GameObject redPlayer;
	public GameObject bluePlayer;
	public GameObject greenPlayer;
	public GameObject yellowPlayer;
	// Use this for initialization
	void Start () {
		winScreen.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		int playerScore = int.Parse(score.text);
		if (playerScore >= 50) {
			winScreen.enabled = true;
			redPlayer.SetActive (false);
			bluePlayer.SetActive (false);
			greenPlayer.SetActive (false);
			yellowPlayer.SetActive (false);
			if (Input.GetButtonDown ("A_1")){
				Application.LoadLevel ("Scene1");
			}
		}
	}
}
