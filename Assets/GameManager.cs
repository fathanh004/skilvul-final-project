using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
   public UnityEvent onPlayerEnter = new UnityEvent();
   public UnityEvent onPlayerExit = new UnityEvent();
   public UnityEvent onNPCEnter = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            onPlayerEnter.Invoke();
        }

        if(other.gameObject.tag == "npc")
        {
            onNPCEnter.Invoke();
        }

    }
    
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            onPlayerExit.Invoke();
        }    
    }
}
