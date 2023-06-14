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
            dialogTexts.Add(new DialogData("/coloo:black/Kembali ke dunia nyata","", () => ChangeBGEnd(1) ));
            dialogTexts.Add(new DialogData("/coloo:black/Kata pamungkas dari Roro Jonggrang membekas di hati dan pikirannya, ia ingin berguna bagi sesama, ia ingin punya teman",""));
            dialogTexts.Add(new DialogData("/coloo:black/Akhirnya ia memutuskan pergi ke lapangan yang ramai","", () => ChangeBGEnd(2) ));
            dialogTexts.Add(new DialogData("/coloo:black/Sesampainya disana, ia menemui anak yang tengah dibullying",""));
            dialogTexts.Add(new DialogData("/coloo:black/dan mencegahnya","" ));
            dialogTexts.Add(new DialogData("/coloo:black/ Aksinya ditonton anak anak sebayanya,",""));
            dialogTexts.Add(new DialogData("/coloo:black/dan berkat aksinya membuat dia terkenal berani dan memiliki banyak teman.","", () => ChangeBGEnd(3) ));

        DialogManager.Show(dialogTexts);
    }
  void NextScene(){
    sceneLoader.LoadScene("Dungeon");
  }
  void LightUp(){
  LeanTween.value(bgEnd.color.a,1,2) ;
  }

    private void Show_Example(int index)
    {
        
        Example[index].SetActive(true);
        
    }

}
