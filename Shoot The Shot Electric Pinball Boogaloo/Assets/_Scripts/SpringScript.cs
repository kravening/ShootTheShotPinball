using UnityEngine;
using System.Collections;

public class SpringScript : MonoBehaviour {


    // Use this for initialization
    void Start()
    {
        TurningOn();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void TurningOn()
    {
        SpringJoint _spring = gameObject.GetComponent<SpringJoint>();

        _spring.spring = 10000;
    }

    public void onKeyDown()
    {


    }
}
