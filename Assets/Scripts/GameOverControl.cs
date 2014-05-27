using UnityEngine;
using System.Collections;

public class GameOverControl : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.JoystickButton0)) {
			
			Application.LoadLevel("Menu");
			
		}
	
	}
	
}
