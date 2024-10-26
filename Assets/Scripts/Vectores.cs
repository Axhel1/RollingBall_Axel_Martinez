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
    [SerializeField] float gravedad;
    [SerializeField] float jumpVelocidad;
    bool grounded;
    
    public float smoothTime = 0.1f;
    float smoothVelocity;
    Vector3 velocityGravedad;
    Vector3 moverPlayer;
    Vector3 moverCam;


    CharacterController player;
    public Animator animator;

    public Transform Camara;


    [SerializeField] float playerSpeed;

 

    // [SerializeField] float fuerzaSalto;




    void Start()
    {
        player = GetComponent<CharacterController>();
        
            
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        animator.SetFloat("horiMov", horizontalMove);
        animator.SetFloat("vertMov", verticalMove);


        moverPlayer = (new Vector3(horizontalMove, 0, verticalMove).normalized);

        DetectarSuelo();

        if (Input.GetButtonDown("Jump") && grounded) { 
        
            velocityGravedad.y = Mathf.Sqrt(jumpVelocidad*-2*gravedad);
            animator.SetBool("IsJump", true);
            Debug.Log("suelo");

        }
        if (!grounded)
        {

            animator.SetBool("IsJump", false);
            Debug.Log("no suelo");

        }






        if (moverPlayer.magnitude > 0f) {

            targetAngulo = Mathf.Atan2(moverPlayer.x, moverPlayer.z) * Mathf.Rad2Deg + Camara.eulerAngles.y;
            angulo = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngulo, ref smoothVelocity, smoothTime);


            transform.rotation = Quaternion.Euler(0f, angulo, 0f);


            moverCam = Quaternion.Euler(0f, targetAngulo, 0f) * Vector3.forward;
            
            player.Move(moverCam.normalized * playerSpeed * Time.deltaTime);

           

        }

        velocityGravedad.y += gravedad * Time.deltaTime;

        player.Move(velocityGravedad * Time.deltaTime);















        
        


    }

  

    private void DetectarSuelo()
    {
        Debug.DrawRay(transform.position, Vector3.down *0.6f,Color.green);
        if (Physics.Raycast(transform.position, Vector3.down, 0.6f))
        {

            grounded = true;

        }
        else { 

            grounded = false;   
        }

       

       
    }

}
