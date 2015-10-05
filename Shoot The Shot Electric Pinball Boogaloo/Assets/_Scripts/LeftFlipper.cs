using UnityEngine;
using System.Collections;

public class LeftFlipper : MonoBehaviour {

    private int rotationSpeed = 60;

   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        TurningJoint();
	}

    void TurningJoint()
    {
        Debug.Log("hey");
        if (this.transform.rotation.y < 350)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

    }
}
