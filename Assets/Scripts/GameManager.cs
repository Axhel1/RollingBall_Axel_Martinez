using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField]Image[] images;
    public static GameManager instance { get; private set; }
    public int Vida { get => vida; set => vida = value; }

    private int vida = 3;
    bool isVivo=true;



    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (vida == 3) {

            images[0].gameObject.SetActive(true);
            images[1].gameObject.SetActive(true);
            images[2].gameObject.SetActive(true);
        }
        if (vida == 2) {

            images[0].gameObject.SetActive(true);
            images[1].gameObject.SetActive(true);
            images[2].gameObject.SetActive(false);

        }
        if (vida == 1) {
            images[0].gameObject.SetActive(true);
            images[1].gameObject.SetActive(false);
            images[2].gameObject.SetActive(false);

        }
    }

    public void PerderVida(int daño) { 
        
        vida -=daño;
    }

    public bool CheckIsVivo()
    {

        if (vida <= 0)
        {

            return isVivo = false;

        }
        else {
            return isVivo = true;

        }
    }




}
