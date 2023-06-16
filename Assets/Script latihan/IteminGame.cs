using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteminGame : MonoBehaviour
{
<<<<<<< Updated upstream
  public GameObject itemCollect;
   private void OnTriggerEnter2D(Collider2D other)
   {
    if(other.gameObject.tag=="Player"){
        PlayerController.instance.ToggleInteractButton(true,this);
=======
    public GameObject itemCollect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController.instance.ToggleInteractButton(true, this);
            
        }
>>>>>>> Stashed changes
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController.instance.ToggleInteractButton(false, this);
            
        }
    }
<<<<<<< Updated upstream
   }

=======
>>>>>>> Stashed changes
}
