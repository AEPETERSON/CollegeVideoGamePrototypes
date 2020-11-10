using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name: Alex Peterson
//Date: February 13, 2018
public class Fighter2StateBehavior : MonoBehaviour
{
    public Animator animateOpponentPunches;
    // Start is called before the first frame update
    void Start()
    {
        animateOpponentPunches = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        float horizontalVal = Input.GetAxis("Horizontal");
        float VerticalVal = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.H))
        {
            transform.Translate(-0.1f, 0f, 0.0f);    //moves p1 charactor left

        }

        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(0.1f, 0f, 0.0f);    //moves p1 character right

        }
        if (Input.GetKey(KeyCode.U))
        {
            transform.Translate(0.0f, 0f, 0.1f);    //moves p1 character up 
        }

        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(0.0f, 0f, -0.1f);   //moves p1 character down
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            animateOpponentPunches.Play("OpponentDefaultPose");     //goes to default opponent pose
        }
        if (Input.GetKeyDown(KeyCode.P))     //when P key is being pressed
        {
            animateOpponentPunches.Play("P2PunchAnimation1");   //executes left arm punch
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            animateOpponentPunches.Play("OpponentDefaultPose", 0);     //goes to default opponent pose
        }
        if (Input.GetKeyDown(KeyCode.O))     //when O key is being pressed
        {
            animateOpponentPunches.Play("P2PunchAnimation2", 0);   //executes right arm punch

        }

    }
}

