﻿using UnityEngine;
using System.Collections;

public class LeftFlipper : MonoBehaviour {

    private int rotationSpeed = 10000;
    private bool _MotorUsage = false;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        //TurningJoint();
	}

    void TurningJoint()
    {
        Rigidbody rigid = gameObject.GetComponent<Rigidbody>();

          HingeJoint hinge = gameObject.GetComponent<HingeJoint>();
          JointMotor motor = hinge.motor;
          hinge.motor = motor;


        if (_MotorUsage == true)
        {
            hinge.useMotor = true;
            
            
        }
        if (_MotorUsage == false)
        {
            hinge.useMotor = false;
            rigid.AddForce(Vector3.back * rotationSpeed, ForceMode.Acceleration);
        }
    }
    public void OnkeyDown()
    {
        _MotorUsage = true;
        TurningJoint();
    }
    public void OnKeyUp()
    {
        _MotorUsage = false;
        TurningJoint();
    }
   
}
