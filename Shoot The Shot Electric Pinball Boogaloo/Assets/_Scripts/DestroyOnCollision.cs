using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class DestroyOnCollision : MonoBehaviour {

	public Transform GateParticle;
	public AudioClip hit;
	public AudioSource audio;

	// Use this for initialization
	void Awake () {
		audio = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "ball")
		{
			audio.PlayOneShot(hit, 1f);
			//instantiate particle system op de plaats van de collision
			Instantiate(GateParticle, col.transform.position, Quaternion.identity);
			col.transform.position = new Vector3(-26, 0, -15); 
			//instantiate particle system op de plaats van de nieuwe spawn
			Instantiate(GateParticle, col.transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
