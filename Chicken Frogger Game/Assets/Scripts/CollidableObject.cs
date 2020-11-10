using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name:Alex Peterson
//Date: 3/20/2019
public class CollidableObject : MonoBehaviour
{
    //public bool isSafe;
    //Rect playerRect;
    //Vector2 playerSize;
    //Vector2 playerPosition;
    //Rect collidableObjectRect;
    //Vector2 collidableObjectSize;
    //Vector2 collidableObjectPosition;
    
    //code that sets up to find any vehicle game objects are colliding with the chicken player.
    void OnTriggerEnter(Collision playerCollision)
    {
        if(playerCollision.gameObject.tag == "CollidableObject")
        {

        }
        //playerSize = playerGameObj.transform.GetComponent<SpriteRenderer>().size;
        //playerPosition = playerGameObj.transform.localPosition;
        //collidableObjectSize = GetComponent<SpriteRenderer>().size;
        //collidableObjectPosition = transform.localPosition;
        //playerRect = new Rect(playerPosition.x - playerSize.x / 2, playerPosition.y - playerSize.y / 2, playerSize.x, playerSize.y);
        //collidableObjectRect = new Rect(collidableObjectPosition.x - collidableObjectSize.x / 2, collidableObjectPosition.y - collidableObjectSize.y / 2, collidableObjectSize.x, collidableObjectSize.y);
        //if(collidableObjectRect.Overlaps(playerRect, true))
        //{
        //    return true;
        //}
        //return false;
    }

    
}
