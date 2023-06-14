using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.Events;
using System;

public class DialogSceneHalamanIstana : MonoBehaviour
{
    public DialogManager DialogManager;

    [SerializeField] GameObject playerCanvas;

    public UnityEvent OnCameraToJin;
    public UnityEvent OnCameraToPlayer;
    public UnityEvent OnQuizStart;
    public UnityEvent OnQuizDone;
    public UnityEvent OnJinFading;


    void Update()
    {
        // if(!objekPrinter.activeSelf){
        //   GameManagerLatihan.instance.joystickGO.SetActive(true);
        //   }
    }

    public void DialogJin()
    {


        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Kamu siapa dan kamu datang dari mana?", "Jin"));
        dialogTexts.Add(new DialogData("/color:black/Aku adalah Adit yang datang dari negeri nan jauh", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Hah! Jadi kamu ya, orang yang dikatakan sang raja", "Jin"));
        dialogTexts.Add(new DialogData("/color:black/Jika kau ingin lewat, hadapi aku dulu!", "Jin"));
        dialogTexts.Add(new DialogData("/color:black/Baiklah aku akan menghadapimu", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Boleh juga nyalimu, kalau begitu ayo kita mulai!", "Jin", () => MulaiQuiz()));

        //penutup dialog untuk menampilkan semua dialog di atas
        DialogManager.Show(dialogTexts);
        //GameManagerLatihan.instance.joystickGO.SetActive(true);

    }

    public void DialogJin2()
    {
        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("/color:black/Tidak mungkin!", "Jin", () => JinFading()));
        dialogTexts.Add(new DialogData("/color:black/Tidaaaakk!", "Jin"));
        dialogTexts.Add(new DialogData("/color:black/Kerja bagus, sekarang kita dapat memasuki istana, ayo cepat kita kalahkan Raja jin", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Baik, ayo!", "Adit", () => QuizDone()));
        DialogManager.Show(dialogTexts);
    }

    private void JinFading()
    {
        OnJinFading.Invoke();
    }

    private void QuizDone()
    {
        OnQuizDone.Invoke();
    }

    public void DialogRoro()
    {
        playerCanvas.SetActive(false);
        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("/color:black/Itu dia istananya", "Roro", () => CameraToJin()));
        dialogTexts.Add(new DialogData("/color:black/Oh tidak! Ada penjaganya, bagaimana ini?", "Adit", () => CameraToPlayer()));
        dialogTexts.Add(new DialogData("/color:black/Sekarang giliranmu untuk bersinar, kau pasti bisa melawan mereka, aku akan berada di belakangmu", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Baiklah", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Sekarang, ayo kita hampiri jin penjaga itu", "Roro", () => PlayerCanvasSetActive()));
        DialogManager.Show(dialogTexts);
    }

    void MulaiQuiz()
    {
        OnQuizStart.Invoke();
    }

    void PlayerCanvasSetActive()
    {
        playerCanvas.SetActive(true);
    }

    void CameraToJin()
    {
        OnCameraToJin.Invoke();
    }

    void CameraToPlayer()
    {
        OnCameraToPlayer.Invoke();
    }
}
