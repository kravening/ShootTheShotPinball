using UnityEngine;
using System.Collections;

public class PlaySoundOnCollision : MonoBehaviour {
	private AudioSource bop;

	void Start(){
		bop = this.gameObject.GetComponent<AudioSource> ();
	}
	void OnCollisionEnter(Collision col)
	{
		//Debug.Log("ayy1");
		if (col.rigidbody != null)
		{
			bop.Play();
		}
	}
}
