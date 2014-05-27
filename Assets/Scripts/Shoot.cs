using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public int ProjectileSpeed = 7;


	void Update () {

		// La balle bouge ici

		transform.Translate(Vector3.down * ProjectileSpeed * Time.deltaTime);

		// Elle disparait en dehors de l'écran ici

		if (transform.position.y > 8 || transform.position.y < -8 )   {

			DestroyObject(gameObject);

		}

		if (transform.position.x > 8 || transform.position.x < -8)  {

			DestroyObject(gameObject);
			
		}

	}

	// La collision entre les ennemis la détruit.

	void OnTriggerEnter ( Collider other )  {
		
		if (other.tag == "Ennemis")  {
			
			DestroyObject(gameObject);
			
		}
		
	}
}
