using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Doublsb.Dialog;
public class EndStory : MonoBehaviour
{
    public bool isEnd=false;
    public static EndStory instance;
    public DialogManager DialogManager;
    public SceneLoader sceneLoader;
    public GameObject[] Example;

    public Image bgEnd;
    public Sprite[] sprtEnd;
    void Awake()
    {
        instance=this;
        if(isEnd){
          ChangeBGEnd(0);
          CeritaEnd();
        }
    }

    void ChangeBGEnd(int indek)
    {
      bgEnd.sprite=sprtEnd[indek];
    }
    void Update()
    {
     // if(!objekPrinter.activeSelf){
       //   GameManagerLatihan.instance.joystickGO.SetActive(true);
   //   }
    }
    public void CeritaEnd()
    {
       var dialogTexts = new List<DialogData>();
            dialogTexts.Add(new DialogData("/color:black/Kembali ke dunia nyata",""));
            dialogTexts.Add(new DialogData("/color:black/Kata pamungkas dari Roro Jonggrang membekas di hati dan pikirannya, ia ingin berguna bagi sesama, ia ingin punya teman","", () => ChangeBGEnd(1) ));
            dialogTexts.Add(new DialogData("/color:black/Akhirnya ia memutuskan pergi ke lapangan yang ramai","", () => ChangeBGEnd(2) ));
            dialogTexts.Add(new DialogData("/color:black/Sesampainya disana, ia menemui anak yang tengah dibullying","" , () => ChangeBGEnd(3) ));
            dialogTexts.Add(new DialogData("/color:black/dan mencegahnya","", () => ChangeBGEnd(4) ));
            dialogTexts.Add(new DialogData("/color:black/Aksinya ditonton anak anak sebayanya,","", () => ChangeBGEnd(5)));
            dialogTexts.Add(new DialogData("/color:black/dan berkat aksinya membuat dia terkenal berani dan memiliki banyak teman.","", () => NextScene()));

        DialogManager.Show(dialogTexts);
    }
  void NextScene(){
    PlayerPrefs.DeleteKey("lastlevel");
    sceneLoader.LoadScene("Credit");

  }


    private void Show_Example(int index)
    {
        
        Example[index].SetActive(true);
        
    }

}
