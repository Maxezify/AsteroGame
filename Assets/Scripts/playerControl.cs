using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	
	public float PlayerSpeed;
	public float RotationSpeed;
	public float life;
	public GameObject PrefabBalle;
	public GameObject Player;
	public float ShootRecha;


	// Update is called once per frame
	void Update () {
		
		float MoveHori = Input.GetAxisRaw("Horizontal") * PlayerSpeed * Time.deltaTime;
		transform.Translate(Vector3.right * MoveHori, Space.World);
		
		float MoveVerti = Input.GetAxisRaw("Vertical") * PlayerSpeed * Time.deltaTime;
		transform.Translate (Vector3.up * MoveVerti, Space.World);
		
		float MoveRotateLeft = Input.GetAxisRaw("Rotate") * RotationSpeed * Time.deltaTime;
		transform.Rotate ( Vector3.forward * MoveRotateLeft);
		

		if (Input.GetKeyDown(KeyCode.JoystickButton5)) {

			Vector3 posis = new Vector3(transform.position.x, transform.position.y, transform.position.z);

			Instantiate(PrefabBalle, posis, transform.rotation);


		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			
			Vector3 posis = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			
			Instantiate(PrefabBalle, posis, transform.rotation);
			
			
		}

		if (life == 0f)  {

			Application.LoadLevel("GameOver");

			// ICI LE GAMEOVER

		}

		if (transform.position.x <= -4.85f) {

			transform.position = new Vector3(-4.85f, transform.position.y, transform.position.z);

		}

		else if (transform.position.x >= 4.85f) {

			transform.position = new Vector3(4.85f, transform.position.y, transform.position.z);

		}

		if (transform.position.y <= -3.50f) {
			
			transform.position = new Vector3(transform.position.x, -3.50f, transform.position.z);
			
		}
		
		else if (transform.position.y >= 3.50f) {
			
			transform.position = new Vector3(transform.position.x, 3.50f, transform.position.z);
			
		}
	}

	void OnTriggerEnter ( Collider other )  {
		
		if (other.tag == "Ennemis")  {
			
			life = 0f;
			
		}

}

}