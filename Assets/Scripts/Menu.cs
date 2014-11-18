using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	bool menuOpen = false;
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
	
	// Use this for initialization
	void Start () {
		UpdateCursorLock ();
		OnGUI ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("LB_1")) {
			menuOpen = !menuOpen;
			UpdateCursorLock();
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
		// Start / Resume
		if (GUI.Button(new Rect(buttonX,menuTop + 1 * buttonDist, buttonWidth, buttonHeight), "Resume")) {
			menuOpen = false;
			UpdateCursorLock();
		}
		
		// Restart
		if (GUI.Button(new Rect(buttonX, menuTop + 2 * buttonDist, buttonWidth, buttonHeight), "Restart")) {
			Application.LoadLevel(Application.loadedLevel);
		}
		
		// Quit (Only works in the Build. Does not work in the eidtor!)
		if (GUI.Button(new Rect(buttonX, menuTop + 3 * buttonDist, buttonWidth, buttonHeight), "Quit")) {
			Application.Quit();
		}
	}
	
	void UpdateCursorLock() {
		Screen.lockCursor = !menuOpen;
		Screen.showCursor = menuOpen;
	}
}
