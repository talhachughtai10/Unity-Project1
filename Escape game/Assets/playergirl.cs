using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playergirl : MonoBehaviour
{

   
    float speed = 5.0f;
    float rotspeed = 110;
    float gravity = 30;
    float rot = 0f;
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator anim;
    public Slider healthbar;
    public GameObject objective;

    void Start()
    {

        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        objective.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        Control();
        GetInput();
    }
    void Control()
    {
        

        {
            if (controller.isGrounded)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                   
                    
                        objective.SetActive(false);
                        anim.SetBool("running", true);
                        anim.SetInteger("condition", 1);
                        moveDir = new Vector3(0, 0, 1);
                        moveDir *= speed;
                        moveDir = transform.TransformDirection(moveDir);
                        GetComponent<CapsuleCollider>().height = 0.99f;
                       

                    
                }
                if (Input.GetKeyUp(KeyCode.UpArrow))
                {
                    anim.SetBool("running", false);
                    anim.SetInteger("condition", 0);
                    moveDir = new Vector3(0, 0, 0);
                    GetComponent<CapsuleCollider>().height = 0.99f;
                    GetComponent<CharacterController>().height = 0.99f;

                }
            }
            rot += Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, rot, 0);
            moveDir.y -= gravity * Time.deltaTime;
            controller.Move(moveDir * Time.deltaTime);

        }
    }

    void GetInput()
    {
      
        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (anim.GetBool("running") == true)
                {

                    anim.SetInteger("condition", 3);
                    moveDir = new Vector3(0, 0, 1);
                    GetComponent<CapsuleCollider>().height = 0.42f;
                    

                }
                if (anim.GetBool("running") == false)
                {
                    anim.SetInteger("condition", 3);
                    moveDir = new Vector3(0, 0, 1);
                    GetComponent<CapsuleCollider>().height = 0.42f;
                   
                }
            }
        }
    
    }

   
    


}