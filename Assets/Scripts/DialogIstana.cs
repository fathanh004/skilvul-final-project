using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class DialogIstana : MonoBehaviour
{
    public static DialogIstana instance;
    public DialogManager dialogManager;
    public GameObject objekPrinter;
    public GameObject kuis;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DialogSceneIstana()
    {
        var dialogTexts  = new List<DialogData>();
        dialogTexts.Add (new DialogData(originalString:"/color:black/Itu dia raja jin nya", character:""));
        dialogTexts.Add(new DialogData(originalString:"/color:black/Kamu bisa melawannya kapan saja ketika kamu sudah siap", character:""));
        dialogTexts.Add(new DialogData(originalString:"/color:black/Haha! aku sudah menunggumu wahai pahlawan, tak perlu basa-basi, mari kita mulai pertarungan kita, akan kubuktikan bahwa aku bisa melawan takdir", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Arghh ternyata ramalan itu benar, aku masih belum cukup kuat untuk melawan takdir", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Awas saja kau roro jonggrang, aku pasti akan kembali", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Oh bandung, akhirnya kamu kembali", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Oh Roro, apa yang terjadi?", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Aku memanggil orang terpilih untuk membantu kita, dia telah mengalahkan raja jin beserta pasukannya", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Terimakasih nak, kamu sungguh hebat", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Sama-sama, sekarang apakah aku bisa pulang", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Tentu saja, tapi sebelum itu ada yang ingin kukatakan", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Tetaplah jadi anak yang baik dan berguna bagi orang-orang disekitarmu seperti kamu yang telah baik dan berguna untuk kami", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Kamu telah melewati banyak tantangan. Sekarang waktunya bagi kamu untuk kembali ke duniamu.", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Terima kasih, Bandung Bondowoso, dan terima kasih atas nasehatmu, Roro Jonggrang.", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Semoga kamu bisa mendapatkan teman yang baik juga di duniamu.", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Kamu siap?", character:""));
        dialogTexts.Add (new DialogData(originalString:"/color:black/Aku siap.", character:""));
    }
}
