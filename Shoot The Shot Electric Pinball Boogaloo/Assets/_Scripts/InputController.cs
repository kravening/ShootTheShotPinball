using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
    // Use this for initialization

    [SerializeField]
    private GameObject _lefty;
	private Flipper _leftFlipper;
    [SerializeField]
    private GameObject _righty;
	private Flipper _rightFlipper;

    [SerializeField]
    private GameObject _springy;
    private Spring _bottomSpring;


	void Awake(){
	}


	void Start()
    {
		_rightFlipper = _righty.GetComponent<Flipper>();
		_leftFlipper = _lefty.GetComponent<Flipper>();
		_bottomSpring = _springy.GetComponent<Spring>();
    }
	
	// Update is called once per frame
	void Update () {

        GetInput();
	
	}

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _leftFlipper.OnkeyDown();

            //call public function in the flipper control that moves the flipper up
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            //call public function in the flipper control that moves the flipper up
            _rightFlipper.OnkeyDown();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            //call public function in the cabinet that creates a ball
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            _leftFlipper.OnKeyUp();
            //call public function in the flipper control that moves the flipper down.
        }

        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            _rightFlipper.OnKeyUp();
            //call public function in the flipper control that moves the flipper down.
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {

        }
    }
}
