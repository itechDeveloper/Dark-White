using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animator;
    
    public PlayerMovement playerMovementScript;

    void Update()
    {
        if (playerMovementScript.rb.velocity.y < -2)
        {
            playerMovementScript.isLanding = true;
        }
        else if (playerMovementScript.rb.velocity.y > -2)
        {
            playerMovementScript.isLanding = false;
        }

        Animate();
    }

    void Animate()
    {
        animator.SetFloat("speed",Mathf.Abs(playerMovementScript.xMov));
        animator.SetBool("isJumping", playerMovementScript.isJumping);
        animator.SetBool("isLanding", playerMovementScript.isLanding);
    }
}
