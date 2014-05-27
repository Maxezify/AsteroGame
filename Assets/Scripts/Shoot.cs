using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public int ProjectileSpeed = 7;


	void Update () {

		transform.Translate(Vector3.down * ProjectileSpeed * Time.deltaTime);

		if (transform.position.y > 8 || transform.position.y < -8 )   {

			DestroyObject(gameObject);

		}

		if (transform.position.x > 8 || transform.position.x < -8)  {

			DestroyObject(gameObject);
			
		}

	}

	void OnTriggerEnter ( Collider other )  {
		
		if (other.tag == "Ennemis")  {
			
			DestroyObject(gameObject);
			
		}
		
	}
}
