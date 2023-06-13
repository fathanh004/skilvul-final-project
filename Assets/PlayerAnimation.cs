using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] Animator animator;
    [SerializeField] AudioSource footstep;
    bool isFootstepPlaying = false;
    Vector2 direction;

    private void Update()
    {
        direction = playerController.Direction;
        direction.Normalize();
        if (direction.magnitude > 0.1f)
        {
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);
        }
        animator.SetFloat("Speed", direction.magnitude);

        if (direction.magnitude > 0.1f && !isFootstepPlaying)
        {
            footstep.Play();
            isFootstepPlaying = true;
        }
        else if (direction.magnitude < 0.1f && isFootstepPlaying)
        {
            footstep.Stop();
            isFootstepPlaying = false;
        }
    }
}
