using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Vectores : MonoBehaviour
{
    [SerializeField] float horizontalMove;
    [SerializeField] float verticalMove;
    [SerializeField] float targetAngulo;
    [SerializeField] float angulo;
    public float smoothTime = 0.1f;
    float smoothVelocity;
    Vector3 moverPlayer;
    Vector3 moverCam;
    CharacterController player;

    public Transform Camara;


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

        if (moverPlayer.magnitude >= 0.1f) {

            targetAngulo = Mathf.Atan2(moverPlayer.x, moverPlayer.z) * Mathf.Rad2Deg + Camara.eulerAngles.y;
            angulo = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngulo, ref smoothVelocity, smoothTime);
            moverCam = Quaternion.Euler(0f, targetAngulo, 0f) * Vector3.forward;
            transform.rotation = Quaternion.Euler(0f, angulo, 0f);
            player.Move(moverCam.normalized * playerSpeed * Time.deltaTime);


        }














        DetectarSuelo();
        /* if (Input.GetButtonDown("Jump")) {


          }*/


    }

  

    private void DetectarSuelo()
    {
        Physics.Raycast(transform.position,Vector3.down,1);

       

       
    }

}
