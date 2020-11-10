using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthBarSlider;
    public int currentHealth;
    public int maxHealth = 100;
    public Text healthText;
    bool isLose;
    void Start()
    {
        currentHealth = maxHealth;
        

    }
    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.name + "has entered trigger event!");
        //if (col.gameObject.tag == "RobotPlayer")
        //{
        //    Debug.Log(col.name + "has entered trigger event!");
        //    currentHealth -= 5;
        //    healthText.text = currentHealth.ToString();

        //}
        //if (col.gameObject.tag == "RobotOpponent")
        //{
        //    Debug.Log(col.name + "has entered trigger event!");
        //    currentHealth -= 5;
        //    healthText.text = currentHealth.ToString();


        //}

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "RobotPlayer")
        {
            Debug.Log(col.name + "has exited trigger event!");
            

        }
        if (col.gameObject.tag == "RobotOpponent")
        {
            Debug.Log(col.name + "has exited trigger event!");
            


        }
    }

    
        
    

   

    

    void Update()
    {
        
        healthBarSlider.maxValue = maxHealth;
        healthBarSlider.value = currentHealth;
        healthText.text = currentHealth.ToString() + " / " + maxHealth.ToString();
        if(currentHealth <= 0)
        {
           
            SceneManager.LoadScene(1);
        }
        
       
    }
    

    

    
}
