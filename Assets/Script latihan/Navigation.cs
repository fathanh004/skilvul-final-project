using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] NPCScript npcScript;

    float speed = 3;
    public bool isActive = true;

    void Update()
    {
        if(isActive)
        {
            Vector3 targetPos = target.transform.position;
            float distance = Vector2.Distance(target.transform.position, transform.position);

            if(PlayerController.instance.direction != Vector2.zero && (distance>0.5f))
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPos,speed * Time.deltaTime);
                npcScript.Direction = targetPos - transform.position;
            }else

           // if (distance < 0.5f)
            {
                npcScript.Direction = Vector2.zero;
            }
        }
    }

    public void IsActive(bool value)
    {
        isActive = value;
    }
}
