using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class CollectItem : MonoBehaviour
{
    public TextMeshProUGUI itemText;
    public AudioSource sfxCollect;
    public UnityEvent onItemComplete = new UnityEvent();

    int itemKayu = 0;
    void Update()
    {
        itemText.text = itemKayu + "/5";

        if(itemKayu == 5)
        {
            onItemComplete.Invoke();
            itemKayu = 0;
        }
    }

    public void AddItem()
    {
        itemKayu ++;
    }

    public void SFXCollect()
    {
        sfxCollect.Play();
    }
}
