using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DictionaryScript : MonoBehaviour
{
    [SerializeField] public GameObject phrase;
    [SerializeField] public Transform panelTransform;

    [SerializeField] public TextMeshProUGUI MainPanel;
    [SerializeField] public static Dictionary<string, string> DictText = new();

    public struct DictData {
        [field: SerializeField] public string key;
        [field: SerializeField] public string text;
    }

    public static void AddText(string key, string text)
    {
        FileReader.Write("example2.txt", JsonUtility.ToJson(new DictData() {key = key, text = text}));
    }

    public void ChangeText(string key) {
        MainPanel.text = DictText[key];
    }

    void Start()
    {
        DictText.Clear();
        foreach (string t in FileReader.Read("example2.txt"))
        {
            var data = JsonUtility.FromJson<DictData>(t);
            if (!DictText.ContainsKey(data.key))
            {
                var p = Instantiate(phrase, panelTransform);
                p.GetComponentInChildren<TextMeshProUGUI>().text = data.key;
                p.GetComponent<Button>().onClick.AddListener(() => ChangeText(data.key));
                DictText.Add(data.key, data.text);
            }
        }
        
    }
}
