using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientosCierra : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float timer = 0;
    [SerializeField] Vector3 dir1;
    [SerializeField] Vector3 dir2;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;

        if (timer >= 0 && timer <= 1.5)
        {
            transform.Translate(dir1 * speed * Time.deltaTime);

        }
        else if (timer >= 1.5 && timer <= 3)
        {
            transform.Translate(dir2 * speed * Time.deltaTime);

        }
        else if (timer >= 3)
        {
            timer = 0;
        }
    }
}
