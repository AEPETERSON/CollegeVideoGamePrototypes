using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name: Alex Peterson
//Date: February 13, 2018
public class FighterStateBehavior : MonoBehaviour
{
    public Animator animatePlayerPunches;
    // Start is called before the first frame update
    void Start()
    {
        animatePlayerPunches = GetComponent<Animator>();        //Gets Animator/Animation component ready to use
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalVal = Input.GetAxis("Horizontal");
        float VerticalVal = Input.GetAxis("Vertical");

        if(Input.GetKey (KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0f, 0.0f);    //moves p1 charactor left
                        
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0f, 0.0f);    //moves p1 character right

        }
        if(Input.GetKey(KeyCode.UpArrow))      
        {
            transform.Translate(0.0f, 0f, 0.1f);    //moves p1 character up 
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.0f, 0f, -0.1f);   //moves p1 character down
        }
        if(Input.GetKeyDown(KeyCode.F))     //when F key is being pressed
        {
            animatePlayerPunches.Play("P1PunchAnimation1", 0);     //executes punching animation for player 1 left arm/fist
        }
        if(Input.GetKeyUp(KeyCode.F))       //when F key is not being pressed
        {
            animatePlayerPunches.Play("PlayerDefaultPose", 0);     //sets back p1 to standing pose
        }
        if(Input.GetKeyDown(KeyCode.D))     //when D key is being pressed
        {
            animatePlayerPunches.Play("P1PunchAnimation2", 0);     //executes punching animation for player 1 right arm/fist
        }
        if(Input.GetKeyUp(KeyCode.D))       //when D key is not being pressed
        {
            animatePlayerPunches.Play("PlayerDefaultPose", 0);
        }
        






    }
}
