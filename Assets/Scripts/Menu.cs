using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	public bool menuOpen = false;
	public GameObject greenPlayer, redPlayer, bluePlayer, yellowPlayer;

	static float centerX = Screen.width/2;
	static float centerY = Screen.height/2;

	// location of the menu
	static float menuLeft = centerX - 50;
	static float menuTop = centerY - 50;
	static float menuWidth = 100;
	static float menuHeight = 100;
	
	static float buttonX = menuLeft + 10;
	static float buttonWidth = 80;
	static float buttonHeight = 20;
	static float buttonDist = 25; // distance between each button 

	static bool oneSelected;
	static bool twoSelected;
	static bool threeSelected;

	static float timer;
	static float lastPressed;
	
	// Use this for initialization
	void Start () {
		UpdateCursorLock ();
		OnGUI ();

		oneSelected = true;
		twoSelected = false;
		threeSelected = false;

		timer = 0.0f;
		lastPressed = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (Input.GetButtonDown("Start_1") || Input.GetButtonDown("Start_2") || Input.GetButtonDown("Start_3") || Input.GetButtonDown("Start_4")) {
			menuOpen = !menuOpen;
			UpdateCursorLock();
		} 
		if((Input.GetAxis("R_YAxis_1") == 1 || Input.GetAxis("R_YAxis_2") == 1 || Input.GetAxis("R_YAxis_3") == 1 || Input.GetAxis("R_YAxis_4") == 1) && timer - lastPressed > 0.15f){
			if (oneSelected) {
				oneSelected = false;
				threeSelected = true;
			}
			else if (twoSelected) {
				twoSelected = false;
				oneSelected = true;
			}
			else if (threeSelected) {
				threeSelected = false;
				twoSelected = true;
			}
			lastPressed = timer;
		}
		else if((Input.GetAxis("R_YAxis_1") == -1 || Input.GetAxis("R_YAxis_2") == -1 || Input.GetAxis("R_YAxis_3") == -1 || Input.GetAxis("R_YAxis_4") == -1) && timer - lastPressed > 0.15f){
			if (oneSelected) {
				oneSelected = false;
				twoSelected = true;
			}
			else if (twoSelected) {
				twoSelected = false;
				threeSelected = true;
			}
			else if (threeSelected) {
				threeSelected = false;
				oneSelected = true;
			}
			lastPressed = timer;
		}
		if(Input.GetButtonDown("A_1") || Input.GetButtonDown("A_2") || Input.GetButtonDown("A_3") || Input.GetButtonDown("A_4")){
			menuSelect();
		}
	}
	
	void OnGUI() {
		// Called each time the Gui needs to be drawn
		if (!menuOpen) {
			//GUI during game
		} else {
			//GUI during pause
			//Background box
			GUI.Box(new Rect(menuLeft, menuTop, menuWidth, menuHeight), "Menu");
			drawHUD();
		}
	}

	void drawHUD() {
		GUI.Toggle(new Rect(buttonX,menuTop + 1 * buttonDist, buttonWidth, buttonHeight), oneSelected, "Resume" ,"Button");
		GUI.Toggle(new Rect(buttonX, menuTop + 2 * buttonDist, buttonWidth, buttonHeight), twoSelected, "Restart" ,"Button");
		GUI.Toggle(new Rect(buttonX, menuTop + 3 * buttonDist, buttonWidth, buttonHeight), threeSelected, "Quit" ,"Button");
	}

	void menuSelect() {
		// Start / Resume
		if (oneSelected) {
			menuOpen = false;
			UpdateCursorLock();
		}
		// Restart
		if (twoSelected) {
			Application.LoadLevel(Application.loadedLevel);
		}
		// Quit (Only works in the Build. Does not work in the eidtor!)
		if (threeSelected) {
			Application.Quit();
		}
	}
	
	void UpdateCursorLock() {
		Screen.lockCursor = !menuOpen;
		Screen.showCursor = menuOpen;
	}
}
