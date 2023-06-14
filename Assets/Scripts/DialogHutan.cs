using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.Events;

public class DialogHutan : MonoBehaviour
{
    public static DialogHutan instance;
    public DialogManager dialogManager;
    public GameObject objekPrinter;
    public GameObject questUI;
    public Transform jinPos;
    public Transform roroPos;

    float speed = 3;
    bool jinPergi = false;
    bool roroPergi = false;
    public UnityEvent onRoroAction = new UnityEvent(); 
    public UnityEvent onAfterAction = new UnityEvent();
    public GameObject[] Example;

    Vector3 lastPos;

    void Awake() 
    {
        instance = this;    
    }
    void Update()
    {
        if(jinPergi)
        {
            jinPos.position = Vector3.MoveTowards(jinPos.position, new Vector3(200,1,0), speed * Time.deltaTime);
        }

        if(roroPergi)
        {
            lastPos = roroPos.position;
            roroPos.position = Vector3.MoveTowards(roroPos.position, new Vector3(-4.5f, 0.6f, 0), speed * Time.deltaTime);
            Invoke("RoroPindah", 1);
        }
    }

    public void Dialog1()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Kita sudah hampir sampai", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Tinggal menyebrangi jembatan ini dan istananya akan terlihat", "Roro"));

        dialogManager.Show(dialogTexts);
    }

    public void Dialog2()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Haha !! Sia - sia kau memanggil bantuan", "Jin"));
        dialogTexts.Add(new DialogData("/color:black/Sekarang kau tidak bisa melewati sungai ini", "Jin", callback: () => JinPergi()));
        dialogTexts.Add(new DialogData("/color:black/Oh tidak !", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Apa yang harus kita lakukan","Adit"));
        dialogTexts.Add(new DialogData("/color:black/Jangan khawatir, aku bisa memperbaiki jembatan ini","Roro"));
        dialogTexts.Add(new DialogData("/color:black/Hanya saja, aku butuh kayu untuk bisa memperbaikinya","Roro"));
        dialogTexts.Add(new DialogData("/color:black/Bisakah kamu mencari 5 kayu untukku ?","Roro", callback: () => MunculkanQuestUI()));

        dialogManager.Show(dialogTexts);
    }

    public void Dialog3()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Terima Kasih!", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Sekarang aku akan mulai memperbaiki jembatan ini dengan sihirku", "Roro", callback: () => RoroPergi()));

        dialogManager.Show(dialogTexts);
    }

    public void Dialog4()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Wow !", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Hebat sekali !", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Itu bukan apa - apa", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Ayo kita segera menuju ke istana", "Roro", callback: () => AfterSihir()));

        dialogManager.Show(dialogTexts);
    }

    void JinPergi()
    {
        jinPergi = true;
    }

    void RoroPergi()
    {
        roroPergi = true;
        onRoroAction.Invoke();
    }

    void AfterSihir()
    {
        onAfterAction.Invoke();
    }

    void MunculkanQuestUI()
    {
        questUI.SetActive(true);
    }

    public void RoroPindah()
    {
        roroPos.position = lastPos;
        roroPergi = false;
    }
}
