using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Name: Alex Peterson
//Date: April 25, 2019

public class Main : MonoBehaviour
{
    static public Main S;
    [Header("Set In Inspector")]
    public GameObject[] prefabEnemies;
    public float enemySpawnPerSec = 0.5f;
    public float enemyDefaultPadding = 1.5f;
    private BoundsCheck bndCheck;
    // Start is called before the first frame update
    void Awake()
    {
        S = this;
        //set bound check to reference the BoundsCheck componentson this GameObject
        bndCheck = GetComponent<BoundsCheck>();
        //Invoke SpawnEnemy Method once (in two seconds, based on default values
        Invoke("SpawnEnemy", 1f / enemySpawnPerSec);
        
    }

    public void SpawnEnemy()
    {
        //Pick a random enemy prefab to instantiate
        int ndx = Random.Range(0, prefabEnemies.Length);
        GameObject go = Instantiate<GameObject>(prefabEnemies[ndx]);
        // Position the enemy above the screen with a random x position
        float enemyPadding = enemyDefaultPadding;
        if(GetComponent<BoundsCheck>() != null)
        {
            enemyPadding = Mathf.Abs(go.GetComponent<BoundsCheck>().radius);
        }
        //Set the initial position for the spawned enemy
        Vector3 pos = Vector3.zero;
        float xMin = -bndCheck.camWidth + enemyPadding;
        float xMax = bndCheck.camWidth - enemyPadding;
        pos.x = Random.Range(xMin, xMax);
        pos.y = bndCheck.camHeight + enemyPadding;
        go.transform.position = pos;

        //Invoke SpawnEnemy() Method Again
        Invoke("SpawnEnemy", 1f / enemySpawnPerSec);
    }

    public void DelayedRestart(float delay)
    {
        Invoke("Restart", delay);
    }

    public void Restart()
    {
        SceneManager.LoadScene("_MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
