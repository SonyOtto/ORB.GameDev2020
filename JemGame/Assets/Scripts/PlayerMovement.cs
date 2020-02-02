using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D controller;
	public Animator animator;
    public Rigidbody2D rig;
   
	public float runSpeed = 10f;   
	float horizontalMove = 0f;
	bool jump = false;

    public AudioSource run;
    //public AudioSource IsJump;

    public float repareRate = 5f;
    float nextRepareTime = 0f;

    // Update is called once per frame
    void Update()
    {
	
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            run.Play();
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            run.Stop();
        }
        if (Time.time >= nextRepareTime)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.SetTrigger("Repare");
                nextRepareTime = Time.time + 0.5f / repareRate;

            }
        }
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetButtonDown("Jump"))
		{
			jump = true;
            //IsJump.Play();
        }
        
    }
	
	//public void OnLanding()
	//{
       
 //   }	
	
	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}

    void OnTriggerEnter2D(Collider2D Other2)
    {
        if (Other2.tag == "Lesnica")
        {
            rig.gravityScale = 0;

        }

    }

    void OnTriggerExit2D(Collider2D Other2)
    {
        if (Other2.tag == "Lesnica")
        {
            rig.gravityScale = 3;

        }

    }
}
