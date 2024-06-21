using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections.Generic;
using UnityEngine.UI;

public class GridItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public static List<GridItem> hoveredItems = new List<GridItem>();
    private TextMeshProUGUI itemText;
    private Image image;
    private Color originalColorImage;
    private Color originalColor;
    private static bool isDragging = false;
    public bool isLocked = false; // Добавленное поле

    void Start()
    {
        itemText = GetComponentInChildren<TextMeshProUGUI>();
        image = GetComponentInChildren<Image>();
        originalColor = itemText.color;
        originalColorImage = image.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (isDragging && !isLocked)
        {
            if (!hoveredItems.Contains(this))
            {
                ChangeColor(Color.gray);
                hoveredItems.Add(this);
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Не требуется действия при выходе указателя
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left && !isLocked)
        {
            isDragging = true;
            if (!hoveredItems.Contains(this))
            {
                ChangeColor(Color.gray);
                hoveredItems.Add(this);
            }
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (isDragging)
        {
            isDragging = false;
            
            foreach (GridItem item in hoveredItems)
            {
                if (!item.isLocked)
                {
                    item.ChangeColor(originalColorImage);
                }
            }
            WordSearchManager.Instance.CheckWord();
        }
    }

    public void ChangeColor(Color color)
    {
        image.color = color;
    }

    public char GetCharacter()
    {
        return itemText.text[0];
    }
}
