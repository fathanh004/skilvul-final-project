using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    [SerializeField] CharacterData characterData;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator.runtimeAnimatorController = characterData.animatorController;
        rb.gravityScale = 0;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = characterData.charSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.runtimeAnimatorController == null) return;
        if (rb.velocity.magnitude > 0.1f)
        {
            animator.SetFloat("Horizontal", rb.velocity.x);
            animator.SetFloat("Vertical", rb.velocity.y);
        }
        animator.SetFloat("Speed", rb.velocity.magnitude);

        //simple movement for testing
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0, 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1, 0);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
