using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name: Alex Peterson
//Date: April 18, 2019

public class HeroPlayer : MonoBehaviour
{
    static public HeroPlayer S;
    [Header("Set in Inspector")]
    //these data fields control the movement of the cannon
    public float speed = 30;
    public float rollMult = -45;
    public float pitchMult = 30;
    public float gameRestartDelay = 2f;
    public GameObject projectilePrefab;
    public float projectileSpeed = 40;
    [Header("Set Dynamically")]
    [SerializeField]
    private float _shieldLevel = 1;
    //this variable holds the last triggered game object
    private GameObject lastTriggerGo = null;

    void Awake()
    {
        if(S == null)
        {
            S = this;  //set the singleton
        }
        else
        {
            Debug.LogError("HeroPlayer.Awake() - Attempted to assign second HeroPlayer.S!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //Pulling info from the Input class
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        //Change transform.position based on the axes
        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;

        //Rotate the cannon to make it feel more dynamic
        transform.rotation = Quaternion.Euler(yAxis * pitchMult, xAxis * rollMult, 0);
        //Allow your atomic cannon to fire when the spacebar key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CannonFire();
        }

        
    }
    //method that sets the cannonball direction of movement and speed when fired with input from spacebar
    void CannonFire()
    {
        GameObject projGO = Instantiate<GameObject>(projectilePrefab);
        projGO.transform.position = transform.position;
        Rigidbody rigidBod = projGO.GetComponent<Rigidbody>();
        rigidBod.velocity = Vector3.up * projectileSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
        Transform rootT = other.gameObject.transform.root;
        GameObject go = rootT.gameObject;
        //print("Triggered: " + go.name);

        //make sure it's not the same trigger event go as last time
        if(go == lastTriggerGo)
        {
            return;
        }
        lastTriggerGo = go;
        if(go.tag == "Enemy")
        {
            _shieldLevel--;
            Destroy(go);
        }
        else
        {
            print("Triggered by non-enemy: " + go.name);
        }

    }

    public float shieldLevel
    {
        get
        {
            return (_shieldLevel);
        }
        set
        {
            _shieldLevel = Mathf.Min(value, 4);
            if(value < 0)
            {
                Destroy(this.gameObject);
                Main.S.DelayedRestart(gameRestartDelay);
            }

        }
    }
}
