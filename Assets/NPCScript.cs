using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    [SerializeField] CharacterData characterData;
    [SerializeField] Animator animator;
    [SerializeField] Canvas canvas;

    Vector2 direction;

    public Vector2 Direction { get => direction; set => direction = value; }

    void Start()
    {
        animator.runtimeAnimatorController = characterData.animatorController;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = characterData.charSprite;
    }

    void Update()
    {
        if (animator.runtimeAnimatorController == null) return;
        if (direction.magnitude > 0.1f)
        {
            // Debug.Log(direction);
            animator.SetFloat("Horizontal", direction.x);
            animator.SetFloat("Vertical", direction.y);
        }
        animator.SetFloat("Speed", direction.magnitude);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (canvas == null) return;
            canvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (canvas == null) return;
            canvas.gameObject.SetActive(false);
        }
    }
}
