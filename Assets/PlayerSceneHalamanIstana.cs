using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerSceneHalamanIstana : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] PlayerController playerController;
    [SerializeField] float speed;
    private Rigidbody2D rb;
    public bool isAnimationOnce = false;
    public UnityEvent OnAnimationDone;

    Vector2 direction; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerController.Direction = direction;
        if (isAnimationOnce)
        {
            playerController.Direction = Vector2.zero;
            this.GetComponent<PlayerSceneHalamanIstana>().enabled = false;
            OnAnimationDone.Invoke();
        }   
    }

    void FixedUpdate()
    {
        if (transform.position != spawnPoint.position && !isAnimationOnce)
        {
            rb.isKinematic = true;
            direction = (spawnPoint.position - transform.position).normalized;
            rb.velocity = direction * speed;
            Debug.Log("rb.velocity" + rb.velocity);

            if (Vector2.Distance(transform.position, spawnPoint.position) < 0.1f)
            {
                rb.velocity = Vector2.zero;
                rb.isKinematic = false;
                isAnimationOnce = true;
            }
        }
    }

}
