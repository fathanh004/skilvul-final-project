using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Animations;

public class Sihir : MonoBehaviour
{
    public Animator anim;
    public UnityEvent onAction = new UnityEvent();

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log(other);
            anim.Play("Sihir");
        }
    }

    void Action() {
        onAction.Invoke();
    } 
}
