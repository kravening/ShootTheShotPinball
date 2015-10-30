using UnityEngine;
using System.Collections;

public class ScoreHit : MonoBehaviour {

    [SerializeField]
    private GameObject _Scores;
	private Score _TheScores;

//	private Flipper _rightFlipper;
    // Use this for initialization
    void Start () {
		_TheScores = _Scores.GetComponent<Score>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ball")
        {
			//Debug.Log("Drop down for what?");
			_TheScores.AddScore();
        }

    }
}
