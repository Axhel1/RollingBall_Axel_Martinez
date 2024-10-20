using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPersonaje : MonoBehaviour

{
    [SerializeField]private Transform respawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SueloMuerte")) {


            GetComponent<CharacterController>().enabled=false;
            this.gameObject.transform.position = respawn.transform.position;
            GetComponent<CharacterController>().enabled = true;

        }
    }



}
