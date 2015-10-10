using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
    // Use this for initialization
    private LeftFlipper _lefty;
    private rightFlipper _righty;

	void Start () {
        _lefty = GetComponent<LeftFlipper>();
        _righty = GetComponent<rightFlipper>();
    }
	
	// Update is called once per frame
	void Update () {

        GetInput();
	
	}

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _lefty.OnkeyDown();
          
            //call public function in the flipper control that moves the flipper up
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            //call public function in the flipper control that moves the flipper up
            _righty.OnkeyDown();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //call public function in the cabinet that creates a ball
        }
        
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            _lefty.OnKeyUp();
            //call public function in the flipper control that moves the flipper down.
        }

        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            _righty.OnKeyUp();
            //call public function in the flipper control that moves the flipper down.
        }
    }
}
