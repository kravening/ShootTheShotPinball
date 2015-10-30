using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class DestroyOnCollision : MonoBehaviour
{

    public Transform GateParticle;
    public AudioClip hit;
    private AudioSource audio;

    // Use this for initialization
    void Awake()
    {
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ball")
        {
            audio.PlayOneShot(hit, 1f);
            Instantiate(GateParticle, this.transform.position, this.transform.rotation);
			Destroy(this.gameObject);
        }
    }
}