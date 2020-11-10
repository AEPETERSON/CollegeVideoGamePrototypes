using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Name: Alex Peterson
//Date: April 25, 2019
public class Projectile : MonoBehaviour
{
    private BoundsCheck bndCheck;
    
    
    
    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (bndCheck.offUp)
        {
            Destroy(gameObject);
        }
        
    }
}
