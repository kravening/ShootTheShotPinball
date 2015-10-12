using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
    // Use this for initialization
    [SerializeField]
    private GameObject _lefty;
    [SerializeField]
    private GameObject _righty;



	void Start()
    {
       
    }
	
	// Update is called once per frame
	void Update () {

        GetInput();
	
	}

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _lefty.GetComponent<LeftFlipper>().OnkeyDown();
          
            //call public function in the flipper control that moves the flipper up
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            //call public function in the flipper control that moves the flipper up
            _righty.GetComponent<rightFlipper>().OnkeyDown();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //call public function in the cabinet that creates a ball
        }
        
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            _lefty.GetComponent<LeftFlipper>().OnKeyUp();
            //call public function in the flipper control that moves the flipper down.
        }

        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            _righty.GetComponent<rightFlipper>().OnKeyUp();
            //call public function in the flipper control that moves the flipper down.
        }
    }
}
