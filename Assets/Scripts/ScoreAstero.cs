using UnityEngine;
using System.Collections;

public class ScoreAstero : MonoBehaviour {

	private GUIText ScoreText;
	public float Score;

	// Use this for initialization
	void Start () {

		ScoreText = GameObject.FindGameObjectWithTag("ScoreLab").GetComponent<GUIText>();
	
	}
	
	// Update is called once per frame
	void Update () {

		ScoreText.text = Score.ToString();
	
	}
	
}
