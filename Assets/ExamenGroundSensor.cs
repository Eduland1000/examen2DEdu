using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamenGroundSensor : MonoBehaviour
{

    public static bool isGrounded;

    public static Animator characterAnimator;

    void Awake()
    {
        characterAnimator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 6)
        {
            isGrounded = true;
            PlayerControler.characterAnimator.SetBool("IsJumping", false);
        }
        
    }
    
    void OnTriggertay2D(Collider2D collider)
    {
         if(collider.gameObject.layer == 6)
         {
            isGrounded = true; 
            
         }
      
    }

    void OnTriggerExit2D(Collider2D collider)
    {
         if(collider.gameObject.layer == 6)
         {
           isGrounded = false; 
           PlayerControler.characterAnimator.SetBool("IsJumping", true);
         }
        
    }

}
