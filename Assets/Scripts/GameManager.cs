using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField]Image[] images;
    public Animator anim;

    private bool damage=false;
    private int vida = 3;
    public static GameManager instance { get; private set; }

    
    public bool Damage { get => damage; set => damage = value; }

    public int Vida { get => vida; set => vida = value; }

    bool isVivo;



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

        if (damage == true)
        {

            anim.SetBool("IsDamage", true);

        }
        else 
        {
            anim.SetBool("IsDamage", false);
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
