using UnityEngine;
using System.Collections;

public class AddForceOnCollision : MonoBehaviour {

	[SerializeField]
	private float _forceAmount = 1000f;
	[SerializeField]
	private float _forceRadius = 1f;

	void OnCollisionEnter(Collision col)
	{
		Debug.Log("ayy1");
		if (col.rigidbody != null)
		{
			col.rigidbody.AddExplosionForce(_forceAmount,transform.position,_forceRadius);
		}
	}
}
