using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    [SerializeField] Transform target;

    float speed = 3;
    bool isActive = true;

    void Update()
    {
        if(isActive)
        {
            Vector3 targetPos = target.transform.position;
            float distance = Vector3.Distance(target.transform.position, transform.position);

            if(distance > 0.5f) 
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos,speed * Time.deltaTime);
            }
        }
    }

    public void IsActive(bool value)
    {
        isActive = value;
    }
}
