using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public SceneFader sceneFader;

    void Start()
    {
        if (sceneFader is null) {
            sceneFader = FindFirstObjectByType<SceneFader>();
        }    
    }

    public void End(bool win) {
        GlobasVar.NextScene = "MainMenu";
        if (win) GlobasVar.FadeText = "У вас получилось убедить Сергала";
        else GlobasVar.FadeText = "У вас не получилось убедить Сергала";
        SceneManager.LoadScene("FadeScene");
    }
}
