using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadePanel : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.Play("Fade Canvas");
    }

    void CloseCanvas()
    {
        canvas.SetActive(false);
    }
}
