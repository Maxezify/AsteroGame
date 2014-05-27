using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {


	public GUITexture Cadre;

	// Use this for initialization
	void Start () {
	

	}

	// Update is called once per frame
	void Update () {

		Time.timeScale = 0f;

		// Le jeu est freeze sur l'UI.

		if (Input.GetKeyDown(KeyCode.JoystickButton0)) {

		//En appuyant sur A, l'UI disparait et le jeu ne freeze plus

			DestroyObject(gameObject);

			Time.timeScale = 1.0f;

		}
			
		}

	
	}
