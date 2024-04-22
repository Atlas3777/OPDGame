using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    [SerializeField] int sceneId;
    public void SelectGameScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void SelectExitScene()
    {
        Debug.Log("Игра закончина");
        Application.Quit();
    }
    public void SelectOptionsScene()
    {
        SceneManager.LoadScene("Options");  
    }
    public void SelectLogbookScene()
    {
        SceneManager.LoadScene("Logbook");

    }
    public void SelectMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
