using UnityEngine;
using System.Collections;

public class EnnemisControl : MonoBehaviour {

	public float EnnemisSpeed;
	public GameObject FirstVagueEnnemis;
	public GameObject explosion;
	public float life;
	private  playerControl Player;
	public float RotateEnnemis;
	public float ScoreDestroy = 30f;
	public float ScoreTouch = 10f;
	private ScoreAstero ScoreText;

	
	// Update is called once per frame
	void Start()  {

		Player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerControl>();

		ScoreText = GameObject.FindGameObjectWithTag("ScoreLab").GetComponent<ScoreAstero>();
        
	}


	void Update () {

		transform.Rotate(Vector3.right * RotateEnnemis *  Time.deltaTime);


		float EnnemisbougeFirstVague = EnnemisSpeed * Time.deltaTime;

		if ( life == 0f)  {

			DestroyObject(gameObject);

			ScoreText.Score += ScoreDestroy;

		}


		transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnnemisbougeFirstVague);

	}
	
	void OnTriggerEnter ( Collider other )  {
		
		if (other.tag == "Balle")  {
			
			Instantiate(explosion, transform.position, transform.rotation);

			life--;

			ScoreText.Score += ScoreTouch;

		}

		if (other.tag == "Ennemis")  {




		}

	}
}
