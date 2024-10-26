using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ColisionPersonaje : MonoBehaviour

{
    [SerializeField]private Transform respawns;
    [SerializeField]private CheckPoint CheckPoint;
    

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SueloMuerte")) {

            
            GetComponent<CharacterController>().enabled=false;
            this.gameObject.transform.position = respawns.transform.position;
            GetComponent<CharacterController>().enabled = true;
            GameManager.instance.Vida = 3;

        }

        if (other.gameObject.CompareTag("Daño"))
        {

            GameManager.instance.PerderVida(1);
            if (!GameManager.instance.CheckIsVivo())
            {
                GetComponent<CharacterController>().enabled = false;
                this.gameObject.transform.position = respawns.transform.position;
                GetComponent<CharacterController>().enabled = true;
                GameManager.instance.Vida=3; 

            }

           


        }

        if (other.gameObject.CompareTag("Daño"))
        {
            StartCoroutine(enumerator());


        }

        if (other.gameObject.CompareTag("Point1"))
        {
            CheckPoint.Pared1 = true; 
            CheckPoint.Pared2 = false;
        }
        if (other.gameObject.CompareTag("Point2"))
        {
            CheckPoint.Pared1 = false;
            CheckPoint.Pared2 = true;
        }

        if (other.gameObject.CompareTag("Meta")) {

            SceneManager.LoadScene(2);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Daño") {
            Debug.Log("COLISION");
            GameManager.instance.PerderVida(1);

            if (!GameManager.instance.CheckIsVivo())
            {
                GetComponent<CharacterController>().enabled = false;
                this.gameObject.transform.position = respawns.transform.position;
                GetComponent<CharacterController>().enabled = true;
                GameManager.instance.Vida = 3;

            }
        }
    }

    IEnumerator enumerator() {

        GameManager.instance.Damage = true;
        yield return new WaitForSeconds(0.4f);
        GameManager.instance.Damage = false;
    }



}
