using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlay : MonoBehaviour
{
    [SerializeField] Navigation navigation;
    void Start()
    {
        navigation.SetSpeed(1);
    }
}
