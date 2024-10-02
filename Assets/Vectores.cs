using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectores : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;



    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(0.1f, 0,0);
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(0, 0 , 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {

           transform.Translate(0, 0, -0.1f);
        }


    }
}
