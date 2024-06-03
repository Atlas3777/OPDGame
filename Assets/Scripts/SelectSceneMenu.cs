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
        DictionaryScript.AddText("Scam", "Scam - это то что нас окружает");
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
        var stringList = FileReader.Read("save.txt");
        if (stringList.Count != 0){
            Save.Data d = JsonUtility.FromJson<Save.Data>(stringList[0]);
            GlobasVar.directionEntry = d.direction;
            SceneManager.LoadScene(d.sceneName);
        }
        else
            SceneManager.LoadScene("Scene_1");
    }
}
