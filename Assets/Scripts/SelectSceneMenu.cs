using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    [SerializeField] string s = "scam";
    [SerializeField] int sceneId;
    public void SelectGameScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void SelectExitScene()
    {
        Debug.Log("���� ���������");
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
    public void SelectDictionaryScene()
    {
        SceneManager.LoadScene("DictionaryScene");
    }
    public void SelectSampleScene()
    {
        // var stringList = FileReader.Read("save.txt");
        // Debug.Log(JsonUtility.FromJson<int>(stringList[0]));
        // GlobasVar.directionEntry = JsonUtility.FromJson<GlobasVar.Direction>(stringList[1]);
        // SceneManager.LoadScene(JsonUtility.FromJson<int>(stringList[0]));
        SceneManager.LoadScene("scene_1");
    }
}
