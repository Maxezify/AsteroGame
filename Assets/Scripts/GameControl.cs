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

		if (Input.GetKeyDown(KeyCode.JoystickButton0)) {

			DestroyObject(gameObject);

			Time.timeScale = 1.0f;

		}
			
		}

	
	}
