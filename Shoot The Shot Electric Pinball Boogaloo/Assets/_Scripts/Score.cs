using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    private int _score = 0;
	public Text scoreText;
    //get{}SET{};
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AddScore()
	{
		_score++;

		scoreText.text = "Score: " + _score;

	}
}
