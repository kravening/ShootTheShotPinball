using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {

    private bool _flipperUsage = false;
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
        float tempSpeed = 0f;
        while(_flipperUsage == true)
        {
            tempSpeed++;
            Debug.Log(tempSpeed);
        }
        if (_flipperUsage == false)
        {
            _spring.spring = tempSpeed;

        }

    }





    public void onKeyDown()
    {
        _flipperUsage = true;
        TurningOn();
    }
    public void onKeyUp()
    {
        _flipperUsage = false;
        TurningOn();
    }
}
