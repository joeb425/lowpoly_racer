using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Transform centerOfMass;

    public float motorTorque = 5000f;
    public float maxSteer = 40f;

    public float Steer { get; set; }
    public float Throttle { get; set; }

    private Rigidbody _rigibody;
    private Wheel[] wheels;

    void Start()
    {
        wheels = GetComponentsInChildren<Wheel>();  // Find all ye wheels and chuck um into array
        _rigibody = GetComponent<Rigidbody>();
        _rigibody.centerOfMass = centerOfMass.localPosition;

    }

    void Update()
    {
  //      Steer = GameManager.Instance.InputController.SteerInput;    // refernzxing the static 
  //      Throttle = GameManager.Instance.InputController.ThrottelInput; 

        foreach (var wheel in wheels)
        {
            wheel.SteerAngle = Steer * maxSteer;
            wheel.Torque = Throttle * motorTorque;        
        }

    }
}
