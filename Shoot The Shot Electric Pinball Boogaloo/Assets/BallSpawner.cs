using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {
	[SerializeField]
	private GameObject ballRed;
	[SerializeField]
	private GameObject ballGreen;
	[SerializeField]
	private GameObject ballWhite;

	private int randomNumber;
	private int maxAmountOfBalls = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SpawnBall(){
		randomNumber = Random.Range(0,3);
		if (maxAmountOfBalls <= 0) {
			return;
		} else {
			if (randomNumber == 0) {
				Instantiate (ballRed, this.transform.position, this.transform.rotation);
			} else if (randomNumber == 1) {
				Instantiate (ballGreen, this.transform.position, this.transform.rotation);
			} else if (randomNumber == 2) {
				Instantiate (ballWhite, this.transform.position, this.transform.rotation);
			}else{
				Instantiate (ballRed, this.transform.position, this.transform.rotation);
			}
			maxAmountOfBalls--;
		}
	}
}
