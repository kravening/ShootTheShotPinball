using UnityEngine;
using System.Collections;

public class RemoveBall : MonoBehaviour {
	private int ballsRemoved = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "ball") {
			Destroy(col.gameObject);
			ballsRemoved++;
			if(ballsRemoved >= 5){
				Application.LoadLevel("menu");
			}
		}
	}
}
