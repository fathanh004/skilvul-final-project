using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.Events;

public class DialogSceneHalamanIstana : MonoBehaviour
{
    public DialogManager DialogManager;
    public UnityEvent OnCameraToJin;
    [SerializeField] GameObject playerCanvas;

    
    void Update()
    {
        // if(!objekPrinter.activeSelf){
        //   GameManagerLatihan.instance.joystickGO.SetActive(true);
        //   }
    }

    public void DialogJin()
    {


        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Kamu siapa dan kamu datang dari mana?", ""));

        dialogTexts.Add(new DialogData("/color:blue/Aku adalah Adit yang datang dari negeri nan jauh", "Adit"));

        dialogTexts.Add(new DialogData("/color:black/Jadi kamu ya orang yang dikatakan sang raja, jika kau ingin lewat, hadapi aku", ""));
        dialogTexts.Add(new DialogData("/color:blue/Baiklah aku akan menghadapimu", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Boleh juga nyalimu, kalau begitu ayo kita mulai!", "", () => MulaiQuiz()));

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
        dialogTexts.Add(new DialogData("/color:black/Sekarang giliranmu untuk bersinar, kau pasti bisa melawan mereka, aku akan menunggumu di sini", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Baiklah", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Semoga beruntung, nak", "Roro", () => playerCanvasSetActive()));
        DialogManager.Show(dialogTexts);
    }

    void MulaiQuiz()
    {
        Debug.Log("Mulai Quiz");
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
