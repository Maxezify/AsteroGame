using UnityEngine;
using System.Collections;

public class GameOverControl : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.JoystickButton0)) {

			//Gestion Game Over, la scène suivante est loadée en appuyant sur A.
			
			Application.LoadLevel("Menu");
			
		}
	
	}
	
}
