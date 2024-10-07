using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectores : MonoBehaviour
{
    [SerializeField] float horizontalMove;
    [SerializeField] float verticalMove;
    CharacterController player;


    [SerializeField] float playerSpeed;
    [SerializeField] float fuerzaSalto;
    Rigidbody rb;
   



    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();         
        

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        player.Move(new Vector3(horizontalMove, 0, verticalMove) * playerSpeed * Time.deltaTime);
        if (Input.GetButtonDown("Jump")) {

          
        }


    }


}