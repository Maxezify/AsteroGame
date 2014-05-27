using UnityEngine;
using System.Collections;

public class DepartEnnemis : MonoBehaviour
{
	public GameObject Ennemis;
	
	IEnumerator SpawnBlock (int wait)	{

		for (int i = 1; i > 5; i++)		{

			Debug.Log("WIN");
			Instantiate (Ennemis, transform.position, transform.rotation);

			StartCoroutine ("SpawnBlock", 1);

			yield return new WaitForSeconds (wait);
		
		}
	}
}