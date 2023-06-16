using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ArrivalAnimation : MonoBehaviour
{
    public UnityEvent OnArrival;
    // Start is called before the first frame update
    void OnEnable()
    {
        this.gameObject.GetComponent<Animator>().Play("Arrive Animation");
    }

    public void Arrive()
    {
        OnArrival.Invoke();
    }
}
