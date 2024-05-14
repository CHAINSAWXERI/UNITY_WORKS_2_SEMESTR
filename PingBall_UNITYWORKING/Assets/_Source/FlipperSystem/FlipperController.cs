using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    [SerializeField] public float flipperForce = 1000f;
    [SerializeField] public KeyCode inputName;
    [SerializeField] public HingeJoint2D hinge;

    void Update()
    {
        if (Input.GetKeyDown(inputName))
        {
            JointMotor2D motor = hinge.motor;
            motor.motorSpeed = -flipperForce;
            hinge.motor = motor;
        }
        else if (Input.GetKeyUp(inputName))
        {
            JointMotor2D motor = hinge.motor;
            motor.motorSpeed = flipperForce;
            hinge.motor = motor;
        }
    }

}
