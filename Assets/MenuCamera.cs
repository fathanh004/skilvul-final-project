using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    [SerializeField] float speed = 0.05f;
    private void Update() {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
    }
}
