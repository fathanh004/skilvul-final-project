using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemInventory : MonoBehaviour
{
    public string namaItem="";
     public string deskripsi="";
     public Outline outlineitem;
   //  public Image imgItem="";
   int kayu;

    public void SelectItem(){
        SistemInventori.instance.SelectAnItem(namaItem,deskripsi);

        outlineitem.enabled=true;
        kayu++;
    }
    public void DeSelectItem(){
       outlineitem.enabled=false;
    }

    private void Update() {
        Debug.Log(kayu);
    }
}
