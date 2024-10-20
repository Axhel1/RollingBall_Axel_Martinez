using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject pausa;
    private bool isPaused=true;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {

            isPaused = !isPaused;
            PausaJuego();

        }
    }

    public void PausaJuego() {

        if (!isPaused)
        {
            Time.timeScale = 0f;
            pausa.SetActive(true); 


        }
        else {

            Time.timeScale = 1f;
            pausa.SetActive(false);
        }
    
    }
}
