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

		//Player et ScoreText amenés ici

		Player = GameObject.FindGameObjectWithTag("Player").GetComponent<playerControl>();

		ScoreText = GameObject.FindGameObjectWithTag("ScoreLab").GetComponent<ScoreAstero>();
        
	}


	void Update () {

		// Rotation naturelle des astéroides

		transform.Rotate(Vector3.right * RotateEnnemis *  Time.deltaTime);

		// Vitesse de l'astéroide calculé

		float EnnemisbougeFirstVague = EnnemisSpeed * Time.deltaTime;

		if ( life == 0f)  {

		// L'astéroide est détruit et le score se met à jour + 10 points.

			DestroyObject(gameObject);

			ScoreText.Score += ScoreDestroy;

		}

		// L'astéroide suit le vaisseau

		transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnnemisbougeFirstVague);

	}
	
	void OnTriggerEnter ( Collider other )  {

		// La collision de la balle fait perdre de la vie à l'astéroide. Le score se met à jour + 30 points.
		
		if (other.tag == "Balle")  {
			
			Instantiate(explosion, transform.position, transform.rotation);

			life--;

			ScoreText.Score += ScoreTouch;

		}

	}
}
