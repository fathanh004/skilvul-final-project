using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class DialogJinSceneHalamanIstana : MonoBehaviour
{
    public static DialogJinSceneHalamanIstana instance;
    public DialogManager DialogManager;

    void Awake()
    {
        instance = this;
    }
    void Update()
    {
        // if(!objekPrinter.activeSelf){
        //   GameManagerLatihan.instance.joystickGO.SetActive(true);
        //   }
    }

    public void BicarasamaNpcRoro()
    {


        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Kamu siapa dan kamu datang dari mana?", ""));

        dialogTexts.Add(new DialogData("/color:blue/Aku adalah Adit yang datang dari negeri nan jauh", ""));

        dialogTexts.Add(new DialogData("/color:black/Jadi kamu ya orang yang dikatakan sang raja, jika kau ingin lewat, hadapi aku", ""));
        dialogTexts.Add(new DialogData("/color:blue/Baiklah aku akan menghadapimu", ""));
        dialogTexts.Add(new DialogData("/color:black/Boleh juga nyalimu, kalau begitu ayo kita mulai!", "", () => MulaiQuiz()));

        //penutup dialog untuk menampilkan semua dialog di atas
        DialogManager.Show(dialogTexts);
        //GameManagerLatihan.instance.joystickGO.SetActive(true);

    }

    void MulaiQuiz()
    {
        Debug.Log("Mulai Quiz");
    }
}
