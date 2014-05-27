using UnityEngine;
using System.Collections;

public class VagueEnnemis : MonoBehaviour {

	public GameObject Ennemis;

	void Start() {

		StartCoroutine(SpawnEnnemies());

	}

	IEnumerator SpawnEnnemies() {

		while(true)	{

			Instantiate(Ennemis, transform.position, transform.rotation);

			yield return new WaitForSeconds (5f);

		}

	}

}