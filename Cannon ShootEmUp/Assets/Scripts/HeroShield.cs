using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name:Alex Peterson
//Date: April 25,2019
public class HeroShield : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float rotationsPerSecond = 0.1f;

    [Header("Set Dynamically")]
    public int levelshown = 0;

    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        
    }

    // Update is called once per frame
    void Update()
    {//read the current shield level form the Hero Player singleton
        int curLevel = Mathf.FloorToInt(HeroPlayer.S.shieldLevel);
        if(levelshown != curLevel)
        {
            levelshown = curLevel;
            //adjust the texture offset to show different shield level
            mat.mainTextureOffset = new Vector2(0.2f * levelshown, 0);
        }
        //rotate the shield a bit every frame in a time-based way
        float rZ = -(rotationsPerSecond * Time.time * 360) % 360f;
        transform.rotation = Quaternion.Euler(0, 0, rZ);
    }
}
