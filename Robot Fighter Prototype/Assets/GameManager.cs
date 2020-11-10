using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name: Alex Peterson
//Date: February 11, 2018
public class GameManager : MonoBehaviour
{
    void Awake()
    {
        Cursor.visible = false;         //set the cursor to be invisible when the main game starts
        Cursor.lockState = CursorLockMode.Locked;       //and lock the cursor when the main game starts
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);            //don't destory this gameobject when loading a new scene
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
