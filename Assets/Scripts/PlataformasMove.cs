using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasMove : MonoBehaviour

   
{

    [SerializeField]float speed;    
    [SerializeField]float timer=0;


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += 1 * Time.deltaTime;
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (timer >= 5) {

            transform.Translate(Vector3.left * speed * Time.deltaTime);


        }
        


        
    }
}
