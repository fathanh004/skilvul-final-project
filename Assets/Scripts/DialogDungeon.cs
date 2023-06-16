using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.Events;

public class DialogDungeon : MonoBehaviour
{
    public static DialogDungeon instance;
    public DialogManager dialogManager;
    public GameObject objekPrinter;
    public GameObject questUI;
    public Transform roroPos;

    float speed = 3;
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
        

        if (roroPergi)
        {
            roroPos.position = Vector3.MoveTowards(roroPos.position, new Vector3(-4.5f, 0.6f, 0), speed * Time.deltaTime);
        }
    }

    public void Dialog1()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nSelamat datang wahai pahlawan", ""));
        dialogTexts.Add(new DialogData("/color:black/MC :\nEeh? Di mana aku? Kenapa aku bisa ada di sini?", ""));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nKita tidak punya banyak waktu, jadi akan aku persingkat saja", ""));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nNamaku Roro Jonggrang dan aku adalah ratu di kerajaan Borobudur ini", ""));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nAku memanggilmu ke dunia ini karena aku membutuhkan bantuanmu untuk mengalahkan pasukan Jin", ""));
        dialogTexts.Add(new DialogData("/color:black/MC :\nJin? Tapi aku hanya anak kecil biasa", ""));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nTidak, kamu adalah manusia terpilih yang memiliki kekuatan untuk melawan jin", ""));
        dialogTexts.Add(new DialogData("/color:black/MC :\nKekuatan apa itu?", ""));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nDengan kekuatanmu, bangsa jin tidak dapat mengutukmu menjadi batu, selain itu kau juga bisa menyerang mereka dengan menjawab pertanyaan-pertanyaan mereka", ""));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nTolong selamatkan kerajaan kami dari Raja Jin yang berada di istanaku, dengan begitu aku dapat mengembalikanmu ke dunia asalmu", ""));
        dialogTexts.Add(new DialogData("/color:black/MC :\nBaiklah", ""));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nTerima kasih! Sekarang kita keluar dulu dari dungeon ini", ""));
        dialogTexts.Add(new DialogData("/color:black/Roro Jonggrang :\nOh iya, sembari kita menuju ke istana, kamu perlu mempersiapkan diri dengan item, kamu dapat menemukan item di perjalanan kita", ""));

        dialogManager.Show(dialogTexts);
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

    void MunculQuestUI()
    {
        questUI.SetActive(true);
    }
}
