using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static GlobasVar;

[AddComponentMenu("My components/ToNextLevel")]
public class ToNextLevel : MonoBehaviour
{
    [Header("������ �����")]
    [SerializeField] public string _sceneName;
    [SerializeField] Direction direction;

    public bool fadeScene = false;

    public string fadeText = "";
    public SceneFader sceneFader;

    void Start()
    {
        if (sceneFader is null) {
            sceneFader = FindFirstObjectByType<SceneFader>();
        }    
    }

    IEnumerator OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == ("Player"))
        {
            if (direction == Direction.Left)
                directionEntry = Direction.Right;
            if (direction == Direction.Right)
                directionEntry = Direction.Left;
            if (direction == Direction.Up)
                directionEntry = Direction.Down;
            if (direction == Direction.Down)
                directionEntry = Direction.Up;

            Save.SaveData(_sceneName, directionEntry);
            yield return sceneFader.FadeIn();

            GlobasVar.NextScene = _sceneName;
            GlobasVar.FadeText = fadeText;
            if (fadeScene) SceneManager.LoadScene("FadeScene");
            else SceneManager.LoadScene(_sceneName);
            
        }
    }

    void SaveScene() {
        FileReader.Write("save.txt", "scam");
        FileReader.Write("save.txt", directionEntry.ToString());
    }
}