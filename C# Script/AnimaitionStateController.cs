using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaitionStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
       animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
             animator.SetBool("isWalking", true); 
        } 

        if(!Input.GetKey("w"))
        {
            animator.SetBool("isWalking", false); 
        }

        if(Input.GetKey("space"))
        {
            animator.SetBool("isJumping", true);
        }
        if(!Input.GetKey("space"))
        {
            animator.SetBool("isJumping", false); 
        }
        if(Input.GetKey("s"))
        {
            animator.SetBool("isBackward", true);
        }
        if(!Input.GetKey("s"))
        {
            animator.SetBool("isBackward", false); 
        }
        if(Input.GetKey("left shift"))
        {
            animator.SetBool("isRunning", true);
        }
        if(!Input.GetKey("left shift"))
        {
            animator.SetBool("isRunning", false); 
        }
    }
}
