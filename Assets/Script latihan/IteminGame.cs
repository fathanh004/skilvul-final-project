using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteminGame : MonoBehaviour
{
  public GameObject itemCollect;
   private void OnTriggerEnter2D(Collider2D other)
   {
    if(other.gameObject.tag=="Player"){
        PlayerController.instance.ToggleInteractButton(true,this);
      
        
    }
   }
    private void OnTriggerExit2D(Collider2D other)
   {
    if(other.gameObject.tag=="Player"){
        PlayerController.instance.ToggleInteractButton(false,this);
        
    }
   }
}
