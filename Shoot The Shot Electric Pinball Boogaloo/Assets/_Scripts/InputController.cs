using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        GetInput();
	
	}

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Debug.Log("left flipper D");
            //call public function in the flipper control that moves the flipper up
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Debug.Log("right flipper D");
            //call public function in the flipper control that moves the flipper up
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Added ball");
            //call public function in the cabinet that creates a ball
        }
        
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            Debug.Log("left flipper U");
            //call public function in the flipper control that moves the flipper down.
        }

        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            Debug.Log("right flipper U");
            //call public function in the flipper control that moves the flipper down.
        }
    }
}
