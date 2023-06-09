using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    string lastSavedScene="";
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        if(!PlayerPrefs.HasKey("lastlevel")){
            PlayerPrefs.SetString("lastlevel","New Scene");
        }
        lastSavedScene= PlayerPrefs.GetString("lastlevel");
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
 public void LoadSavedScene()
    {
        SceneManager.LoadScene(lastSavedScene);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        //Application.Quit();
    }
}
