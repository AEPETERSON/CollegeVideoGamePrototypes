using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name: Alex Peterson
//Date: March 18,2019
public class PlayerMovement : MonoBehaviour
{
    public Animator animatePlayerMovement;
    private Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;
        animatePlayerMovement = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
        
    }

    private void UpdatePosition()
    {
        //constantly updates the players movement and allows the player to move within the parameters of the level background.
        //player can move up, down, left and right 1 space at a time but cannot leave the background of the level
        Vector2 pos = transform.localPosition;
        float horizontalVal = Input.GetAxis("Horizontal");
        float VerticalVal = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.UpArrow))
        {
           animatePlayerMovement.Play("PlayerMoveUp");
            if (pos.y < -158)
            {
                pos += Vector2.up;
            }

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            animatePlayerMovement.Play("PlayerMoveDown");
            if (pos.y > -440)
            {
                pos += Vector2.down;
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animatePlayerMovement.Play("PlayerMoveLeft");
            if (pos.x > -1049)
            {
                pos += Vector2.left;
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animatePlayerMovement.Play("PlayerMoveRight");
            if (pos.x < -350)
            {
                pos += Vector2.right;
            }
        }

        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animatePlayerMovement.Play("PlayerDefaultRight");
            
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animatePlayerMovement.Play("PlayerDefaultLeft");

        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animatePlayerMovement.Play("PlayerDefaultUp");
            
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animatePlayerMovement.Play("PlayerDefaultDown");

        }
        transform.localPosition = pos;       

    }

    
        void OnTriggerEnter(Collider collidable)
        {
            if (collidable.gameObject.tag == "CollidableObject")
            {
                Debug.Log("Is Not Safe");
                transform.localPosition = startPosition;
            }
            //searches for all collidable objects in the game and any collidable object that touches the player sends the player back to the starting game position 
            //GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("CollidableObject");
            //foreach(GameObject go in gameObjects)
            //{
            //    CollidableObject collidableObject = go.GetComponent<CollidableObject>();
            //    if(collidableObject.IsColliding(this.gameObject))
            //    {
            //        if (collidableObject.isSafe == true)
            //        {
            //            Debug.Log("Is Safe");
            //        }
            //        if(collidableObject.isSafe == false)
            //        {
            //            Debug.Log("Is Not Safe");
            //            transform.localPosition = startPosition;
            //        }
            //    }
            //}
        }
}
