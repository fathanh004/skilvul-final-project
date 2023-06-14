using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Doublsb.Dialog;


public class DialogIstana : MonoBehaviour
{
    public static DialogIstana instance;
    public DialogManager dialogManager;
    public GameObject objekPrinter;
    public GameObject kuis;
    public SpriteRenderer rajaJin;
    

    public UnityEvent onBandungBerubah = new UnityEvent();

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Start()
    {
        Dialog1();
    }

    public void Dialog1()
    {
        var dialogTexts = new List<DialogData>();
        
        dialogTexts.Add (new DialogData(originalString:"/color:black/Itu dia raja jin nya", character:"Roro"));
        dialogTexts.Add(new DialogData(originalString:"/color:black/Kamu bisa melawannya kapan saja ketika kamu sudah siap", character:"Roro"));

        dialogManager.Show(dialogTexts);
    }

    public void Dialog2()
    {
        var dialogTexts = new List<DialogData>();
        
        dialogTexts.Add(new DialogData(originalString:"/color:black/Haha!", character:"Raja Jin"));
        dialogTexts.Add(new DialogData("/color:black/Aku sudah menunggumu wahai pahlawan", "Raja Jin"));
        dialogTexts.Add(new DialogData("/color:black/Tak perlu basa-basi, mari kita mulai pertarungan kita,", "Raja Jin"));
        dialogTexts.Add(new DialogData(originalString:"/color:black/Akan kubuktikan bahwa aku bisa melawan takdir", character:"Raja Jin", () => MunculkanKuis()));

        dialogManager.Show(dialogTexts);
    }

    public void Dialog3()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add (new DialogData(originalString:"/color:black/Arghh ternyata ramalan itu benar", character:"Raja Jin"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Aku masih belum cukup kuat untuk melawan takdir", character:"Raja Jin", () => RajaJinMenghilang()));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Awas saja kau roro jonggrang", character:"Raja Jin"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Aku pasti akan kembali", character:"Raja Jin", () => BandungBerubah()));
    
        dialogManager.Show(dialogTexts);
    }

    public void Dialog4()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add (new DialogData(originalString:"/color:black/Oh bandung, akhirnya kamu kembali", character:"Roro"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Oh Roro, apa yang terjadi?", character:"Bandung"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Aku memanggil orang terpilih untuk membantu kita", character:"Roro"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Dia telah mengalahkan raja jin beserta pasukannya", character:"Roro"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Terimakasih nak", character:"Bandung"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Kamu sungguh hebat", character:"Bandung"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Sama-sama, sekarang apakah aku bisa pulang", character:"Adit"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Tentu saja", character:"Roro"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Tapi sebelum itu ada yang ingin kukatakan", character:"Roro"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Tetaplah jadi anak yang baik dan berguna bagi orang-orang disekitarmu seperti kamu yang telah baik dan berguna untuk kami", character:"Roro"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Kamu telah melewati banyak tantangan", character:"Bandung"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Sekarang waktunya bagi kamu untuk kembali ke duniamu", character:"Bandung"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Terima kasih, Bandung Bondowoso", character:"Adit"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Dan terima kasih atas nasehatmu, Roro Jonggrang", character:"Adit"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Semoga kamu bisa mendapatkan teman yang baik juga di duniamu", character:"Roro"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Kamu siap?", character:"Bandung"));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Aku siap", character:"Adit"));
    
        dialogManager.Show(dialogTexts);
    }

    void MunculkanKuis()
    {
        kuis.SetActive(true);
    }

    void RajaJinMenghilang()
    {
        
    }

    void BandungBerubah()
    {
        onBandungBerubah.Invoke();
        Invoke("Dialog4", 1);
    }
}
