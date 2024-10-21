using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    
    [SerializeField] Transform check;
    [SerializeField] Transform check2;
    bool pared1;
    bool pared2;

    public bool Pared1 { get => pared1; set => pared1 = value; }
    public bool Pared2 { get => pared2; set => pared2 = value; }

    void Update()
    {
        if (pared1) { 
        
            gameObject.transform.position = check.transform.position;
        }
        if (pared2)
        {
            gameObject.transform.position = check2.transform.position;
        }
    }
}
