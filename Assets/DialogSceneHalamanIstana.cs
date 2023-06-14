using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.Events;

public class DialogSceneHalamanIstana : MonoBehaviour
{
    public DialogManager DialogManager;
    
    [SerializeField] GameObject playerCanvas;

    public UnityEvent OnCameraToJin;
    public UnityEvent OnQuizStart;

    
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

    public void DialogRoro()
    {
        playerCanvas.SetActive(false);
        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("/color:black/Itu dia istananya", "Roro", () => CameraToJin()));
        dialogTexts.Add(new DialogData("/color:black/Oh tidak! Ada penjaganya, bagaimana ini?", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Sekarang giliranmu untuk bersinar, kau pasti bisa melawan mereka, aku akan berada di belakangmu", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Baiklah", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Sekarang, ayo kita hampiri jin penjaga itu", "Roro", () => playerCanvasSetActive()));
        DialogManager.Show(dialogTexts);
    }

    void MulaiQuiz()
    {
        OnQuizStart.Invoke();
    }

    void playerCanvasSetActive()
    {
        playerCanvas.SetActive(true);
    }

    void CameraToJin()
    {
        OnCameraToJin.Invoke();
        Debug.Log("Camera to Jin");
    }
}
