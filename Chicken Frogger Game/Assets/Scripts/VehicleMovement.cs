using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name:Alex Peterson
//Date: 3/20/2019
public class VehicleMovement : MonoBehaviour
{
    public Animator VehicleAnimation;
    public float vehicleSpeed = 2f;
    public bool moveRight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vehiclePosition = transform.localPosition;
        if(moveRight)
        {
            //moves vehicles to the right and respawns the vehicle to the far left side of screen when the car reaches the far right side of the level background and repeats
            vehiclePosition.x += Vector2.right.x * vehicleSpeed * Time.deltaTime;
            if(vehiclePosition.x >= 300)
            {
                vehiclePosition.x = -350;
            }
        }
        else
        {   //moves vehicles to the left and respawns the vehicle to the far right side of the level when the car reaches the far left side of the level background and repeats
            vehiclePosition.x += Vector2.left.x * vehicleSpeed * Time.deltaTime;
            VehicleAnimation.Play("SemiTruckMovingAnimation");
            VehicleAnimation.Play("CarMovingAnimation");
            if (vehiclePosition.x <= -350)
            {
                vehiclePosition.x = 300;
            }

        }
        //updates both vehicles local position as the game runs
        transform.localPosition = vehiclePosition;
    }
}
