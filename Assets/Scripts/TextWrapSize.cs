using TMPro;
using UnityEngine;

public class TextWrapSize : MonoBehaviour
{
    private TextMeshProUGUI PhraseText;
    private RectTransform Rect;
    void Start()
    {
        Rect = GetComponent<RectTransform>();
        PhraseText = GetComponentInChildren<TextMeshProUGUI>();
        var countChars = PhraseText.text.Length;
        Rect.sizeDelta = new Vector2(Rect.rect.width, (countChars/80+1)*60);
    }

}
