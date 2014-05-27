using UnityEngine;
using System.Collections;

public class RotateMenu : MonoBehaviour {

	public float RotatePlayer;

	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.back * RotatePlayer *  Time.deltaTime);
	
	}
}
