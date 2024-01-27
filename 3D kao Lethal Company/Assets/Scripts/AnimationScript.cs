using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
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
        bool IsWalkingFront = animator.GetBool("IsWalkingFront");
        bool IsWalkingBack = animator.GetBool("IsWalkingBack");
        bool IsWalkingLeft = animator.GetBool("IsWalkingLeft");
        bool IsWalkingRight = animator.GetBool("IsWalkingRight");
        bool IsJumping = animator.GetBool("IsJumping");
        bool IsRuning = animator.GetBool("IsRuning");
        bool forwardpressed = Input.GetKey("w");
        bool backwardpressed = Input.GetKey("s");
        bool leftpressed = Input.GetKey("a");
        bool rightpressed = Input.GetKey("d");
        bool jumppressed = Input.GetKey("space");
        bool runpressed = Input.GetKey("left shift");
        if (!IsWalkingFront && forwardpressed)
        {
            animator.SetBool("IsWalkingFront", true);
        }

        if (IsWalkingFront && !forwardpressed)
        {
            animator.SetBool("IsWalkingFront", false);
        }

        if (!IsWalkingBack && backwardpressed)
        {
            animator.SetBool("IsWalkingBack", true);
        }

        if (IsWalkingBack && !backwardpressed)
        {
            animator.SetBool("IsWalkingBack", false);
        }

        if (!IsWalkingLeft && leftpressed)
        {
            animator.SetBool("IsWalkingLeft", true);
        }

        if (IsWalkingLeft && !leftpressed)
        {
            animator.SetBool("IsWalkingLeft", false);
        }

        if (!IsWalkingRight && rightpressed)
        {
            animator.SetBool("IsWalkingRight", true);
        }

        if (IsWalkingRight && !rightpressed)
        {
            animator.SetBool("IsWalkingRight", false);
        }

        if (!IsJumping && jumppressed)
        {
            animator.SetBool("IsJumping", true);
        }

        if (IsJumping && !jumppressed)
        {
            animator.SetBool("IsJumping", false);
        }

        if (!IsRuning && (runpressed && forwardpressed))
        {
            animator.SetBool("IsRuning", true);
        }

        if (IsRuning && (!runpressed || !forwardpressed))
        {
            animator.SetBool("IsRuning", false);
        }
    }
}
