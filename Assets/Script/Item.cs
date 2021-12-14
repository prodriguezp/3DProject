using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public static int CoinsCount = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        CoinsCount++;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            CoinsCount--;
            
            if(CoinsCount==0)   
                Debug.Log("Recogiste todas :o");
        }        
    }
    
    
}
