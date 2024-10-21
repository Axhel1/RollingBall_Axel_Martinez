using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Rotar : MonoBehaviour
{
    [SerializeField]private float vel;
    [SerializeField] Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(dir,vel*Time.deltaTime);
    }
}
