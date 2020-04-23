using UnityEngine;
using System.Collections;

public class menumanager : MonoBehaviour {
	public menumateri currentMenu;
	// Use this for initialization
	void Start () {
		ShowMenu (currentMenu);
	}
	
	// Update is called once per frame
	public void ShowMenu (menumateri menu) {
		if (currentMenu != null) {
			currentMenu.IsOpen = false;
		}
		currentMenu = menu;
		currentMenu.IsOpen = true;
	}
}
