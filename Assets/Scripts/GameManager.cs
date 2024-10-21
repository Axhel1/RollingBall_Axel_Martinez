using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public  TMP_Text vidas;
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
        vidas.text = vida.ToString();
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
