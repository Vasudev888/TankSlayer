using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    public GameObject tankTurrent;
    public Transform fireTransform;
    
/*    public Color tankColor;*/

    float horizontalInput;
    float verticalInput;



    public Joystick joystick;

    public Rigidbody shellRb;
    public TankController tankController;

    private void Start()
    {
        /*rigidBody = GetComponent<Rigidbody>();*/
        tankTurrent.GetComponent<Renderer>().material.color = tankController.TankModel.Color;
    }


    private void FixedUpdate()
    {
/*        horizontalInput = joystick.Horizontal;
        verticalInput = joystick.Vertical;
        tankController.Move(verticalInput);
        tankController.Turn(horizontalInput);*/

    }
}
