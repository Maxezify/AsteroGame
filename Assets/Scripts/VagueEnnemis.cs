using UnityEngine;
using System.Collections;

public class VagueEnnemis : MonoBehaviour {

	public GameObject Ennemis;

	void Start() {

		//Utilisation de la coroutine pour la vague.

		StartCoroutine(SpawnEnnemies());

	}

	// Les ennemis s'instencie tous les 5 secondes sur différents GameObjects.

	IEnumerator SpawnEnnemies() {

		while(true)	{

			Instantiate(Ennemis, transform.position, transform.rotation);

			yield return new WaitForSeconds (5f);

		}

	}

}