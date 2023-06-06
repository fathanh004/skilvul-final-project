using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] VariableJoystick joystick;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;

    Vector2 direction;

    public Vector2 Direction { get { return direction; } }

    private void Start()
    {
        rb.gravityScale = 0;
    }

    private void Update()
    {
        var horizontal = joystick.Horizontal;
        var vertical = joystick.Vertical;
        direction = new Vector2(horizontal, vertical);
        direction.Normalize();
        if (direction.magnitude > 0.1f)
        {
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);
        }
        animator.SetFloat("Speed", direction.magnitude);
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

}
