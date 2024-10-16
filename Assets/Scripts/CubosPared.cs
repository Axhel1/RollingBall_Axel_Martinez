using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosPared : MonoBehaviour
{
    // Start is called before the first frame update
    private bool inciartimer;



    // Update is called once per frame
    void Update()
    {
        if (inciartimer) { 
            
            inciartimer = false;    
        
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) { 
        
            Time.timeScale = 0.2f;
            inciartimer = true;


        }
    }
}
