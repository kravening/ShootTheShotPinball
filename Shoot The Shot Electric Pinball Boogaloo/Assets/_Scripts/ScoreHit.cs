using UnityEngine;
using System.Collections;

public class ScoreHit : MonoBehaviour {

    [SerializeField]
    private GameObject _Scores;

    // Use this for initialization
    void Start () {
  //      _Scores = _Scores.GetComponent<Score>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ball")
        {
       //     _Scores._score -= 40;
        }

    }
}
