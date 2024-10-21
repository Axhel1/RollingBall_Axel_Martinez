using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CargarMenu",5);
    }

    // Update is called once per frame

    public void CargarMenu() {

        SceneManager.LoadScene(0);
    }
}
