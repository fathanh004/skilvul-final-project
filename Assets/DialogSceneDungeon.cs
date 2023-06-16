using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.Events;
using System;

public class DialogSceneDungeon : MonoBehaviour
{
    public DialogManager DialogManager;
    public UnityEvent OnDialog1Selesai;


    void Update()
    {
        // if(!objekPrinter.activeSelf){
        //   GameManagerLatihan.instance.joystickGO.SetActive(true);
        //   }
    }

    public void Dialog1()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:black/Selamat datang wahai pahlawan", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Eeh? Di mana aku? Kenapa aku bisa ada di sini?", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Kita tidak punya banyak waktu, jadi akan aku persingkat saja", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Namaku Roro Jonggrang dan aku adalah ratu di kerajaan Borobudur ini", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Aku memanggilmu ke dunia ini karena aku membutuhkan bantuanmu untuk mengalahkan pasukan Jin", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Jin? Tapi aku hanya anak kecil biasa", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Tidak, kamu adalah manusia terpilih yang memiliki kekuatan untuk melawan jin", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Kekuatan apa itu?", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Dengan kekuatanmu, bangsa jin tidak dapat mengutukmu menjadi batu, selain itu kau juga bisa menyerang mereka dengan menjawab pertanyaan-pertanyaan mereka", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Tolong selamatkan kerajaan kami dari Raja Jin yang sedang menguasai istanaku", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Baiklah, akan kucoba", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Terima kasih, nak!", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Tapi setelah itu aku bisa kembali ke asalku kan?", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Bandung Bondowoso yang dikutuk oleh Raja Jin dapat memulangkanmu, tapi kau harus mengalahkan Raja Jin terlebih dahulu untuk mematahkan kutukannya", "Roro"));
        dialogTexts.Add(new DialogData("/color:black/Baiklah", "Adit"));
        dialogTexts.Add(new DialogData("/color:black/Kalau begitu sekarang kita keluar dulu dari tempat ini", "Roro", ()=>Dialog1Selesai()));
    
        //penutup dialog untuk menampilkan semua dialog di atas
        DialogManager.Show(dialogTexts);
        //GameManagerLatihan.instance.joystickGO.SetActive(true);

    }

    void Dialog1Selesai() {
        OnDialog1Selesai.Invoke();
    }

}
