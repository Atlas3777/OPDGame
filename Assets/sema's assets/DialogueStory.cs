using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cinemachine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DialogueStory : MonoBehaviour
{
    [SerializeField] private Story[] _stories;

    public GameObject MainButton;
    public CinemachineVirtualCamera VCamera;

    public TextMeshProUGUI text_panel;

    public Transform panel;

    private Dictionary<string, Story> _storiesDictionary;

    private List<GameObject> buttons = new List<GameObject>();
    private DialogueManager dm;

    [Serializable]
    public struct Story
    {
        [field: SerializeField] public string Tag {get; private set;}
        [field: SerializeField] public string Text {get; private set;}
        [field: SerializeField] public string StopTag {get; private set;}
        [field: SerializeField] public Answer[] Answers {get; private set;}
    }

    [Serializable]

    public class Answer
    {
        [field: SerializeField] public string Text {get; private set;}
        [field: SerializeField] public string ResponseText {get; private set;}
        [field: SerializeField] public string NewText {get; private set;}
        public bool IsUsed = false;
    }

    private void Start()
    {
        _storiesDictionary = _stories.ToDictionary(key => key.Tag, x => x);
        dm = FindFirstObjectByType<DialogueManager>();
    }

    public void StartStory()
    {
        ChangeStory("start");
        dm.StartDialogue();
        VCamera.Priority = 100;
    }

    public void StopStory()
    {
        dm.StopDialogue();
        VCamera.Priority = 1;
    }

    private void ChangeStory(string tag, string Newtext = "")
    {
        var children = new List<GameObject>();
        foreach (Transform child in panel) children.Add(child.gameObject);
        children.ForEach(child => Destroy(child));
        var story = _storiesDictionary[tag];
        if (Newtext != "" || Newtext != string.Empty) text_panel.text = Newtext;
        else text_panel.text = story.Text;
        foreach (var answer in story.Answers)
        {
            if (answer.IsUsed) continue;
            GameObject button = Instantiate(MainButton, panel);
            var text = button.GetComponentInChildren<TextMeshProUGUI>();
            text.text = answer.Text;
            if (answer.ResponseText == "stop") 
                button.GetComponent<Button>().onClick.AddListener(() => StopStory());
            else
                button.GetComponent<Button>().onClick.AddListener(() => 
                {
                    //FileReader.Termins["st"] = true;
                    FileReader.Write(story.Text);
                    FileReader.Write(text.text);
                    FileReader.Read();

                    Logbook.AddText(story.Text);
                    Logbook.AddText(text.text);


                    answer.IsUsed = true;
                    ChangeStory(answer.ResponseText, answer.NewText);
                }
                );
        }
        if (story.Answers.All(x => x.IsUsed)) ChangeStory(story.StopTag, Newtext);
    }

}
