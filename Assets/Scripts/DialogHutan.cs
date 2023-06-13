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
            roroPos.position = Vector3.MoveTowards(roroPos.position, new Vector3(-4.5f, 0.6f, 0), speed * Time.deltaTime);
        }
    }

    public void Dialog1()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nKita sudah hampir sampai", ""));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nTinggal menyebrangi jembatan ini dan istananya akan terlihat", ""));

        dialogManager.Show(dialogTexts);
    }

    public void Dialog2()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Jin :\nHaha !! Sia - sia kau memanggil bantuan", ""));
        dialogTexts.Add(new DialogData("/color:black/Jin :\nSekarang kau tidak bisa melewati sungai ini", "", callback: () => JinPergi()));
        dialogTexts.Add(new DialogData("/color:black/Jin pergi..."));
        dialogTexts.Add(new DialogData("/color:black/MC :\nOh tidak !"));
        dialogTexts.Add(new DialogData("/color:black/MC :\nApa yang harus kita lakukan"));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nJangan khawatir, aku bisa memperbaiki jembatan ini"));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nHanya saja, aku butuh kayu untuk bisa memperbaikinya"));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nBisakah kamu mencari 5 batang kayu untukku ?", callback: () => MunculkanQuestUI()));

        dialogManager.Show(dialogTexts);
    }

    public void Dialog3()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nTerima Kasih!"));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nSekarang aku akan mulai memperbaiki jembatan ini dengan sihirku", callback: () => RoroPergi()));

        dialogManager.Show(dialogTexts);
    }

    public void Dialog4()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/MC :\nWow !"));
        dialogTexts.Add(new DialogData("/color:black/MC :\nHebat sekali !"));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nItu bukan apa - apa"));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nAyo kita segera menuju ke istana", callback: () => AfterSihir()));

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
}
