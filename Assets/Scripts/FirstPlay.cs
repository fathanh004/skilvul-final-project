using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlay : MonoBehaviour
{
    [SerializeField]
    private GameObject character; // Reference to the character game object
    private Animator animator; // Reference to the animator component

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // Get the animator component
        StartCoroutine(DisableCharacterDuringAnimation());
    }

    IEnumerator DisableCharacterDuringAnimation()
    {
        // Disable the character
        character.SetActive(false);

        // Play the animation
        animator.Play("Arrive Animation");

        // Wait until the animation finishes
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        // Enable the character
        character.SetActive(true);

        // Resume normal animation playback
        animator.enabled = true;

    }
}
