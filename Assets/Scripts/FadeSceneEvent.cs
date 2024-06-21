using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeSceneEvent : MonoBehaviour
{
    public TextMeshProUGUI panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.text = GlobasVar.FadeText;
    }

    public void NextScene() {
        SceneManager.LoadScene(GlobasVar.NextScene);
    }

}
