using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Vectores : MonoBehaviour
{
    [SerializeField] float horizontalMove;
    [SerializeField] float verticalMove;
    [SerializeField] float TargetAngulo;
    [SerializeField] float Angulo;
    Vector3 moverPlayer;
    CharacterController player;


    [SerializeField] float playerSpeed;
   // [SerializeField] float fuerzaSalto;

   



    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        
            
        

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        moverPlayer = new Vector3(horizontalMove, 0, verticalMove).normalized; 
        player.Move(moverPlayer * playerSpeed * Time.deltaTime);

        TargetAngulo= Mathf.Atan2(moverPlayer.x,moverPlayer.z)*Mathf.Rad2Deg;
        


        
        
        
        
        
        DetectarSuelo();
        /* if (Input.GetButtonDown("Jump")) {


          }*/


    }

  

    private void DetectarSuelo()
    {
        Physics.Raycast(transform.position,Vector3.down,1);

       

       
    }

}
