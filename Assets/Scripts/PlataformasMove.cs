using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasMove : MonoBehaviour

   
{

    [SerializeField]float speed;    
    [SerializeField]float timer=0;
    [SerializeField]Vector3 dir1;
    [SerializeField]Vector3 dir2;


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += 1 * Time.deltaTime;

        if (timer >= 0 && timer <= 5)
        {
            transform.Translate(dir1 * speed * Time.deltaTime);

        }
        else if (timer >= 5 && timer <= 10)
        {
            transform.Translate(dir2 * speed * Time.deltaTime);

        }
        else if (timer >= 10) {
            timer = 0;
        }



         
    }
}
