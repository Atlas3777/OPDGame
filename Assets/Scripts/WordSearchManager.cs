using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class WordSearchManager : MonoBehaviour
{
    public static WordSearchManager Instance;
    public GameObject gridItemPrefab;
    public Transform gridParent;
    public int gridWidth = 10; // ������ �����
    public int gridHeight = 10; // ������ �����
    public List<WordPosition> wordsToPlace = new List<WordPosition>();
    private List<string> foundWords = new List<string>(); // ������ ��������� ����

    private char[,] grid;
    private List<GameObject> gridItems = new List<GameObject>();

    public delegate void WordsFoundHandler();

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        GenerateGrid();
        PlaceWordsInGrid();
    }

    void GenerateGrid()
    {
        string russianAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        grid = new char[gridWidth, gridHeight];
        for (int y = 0; y < gridHeight; y++)
        {
            for (int x = 0; x < gridWidth; x++)
            {
                GameObject gridItem = Instantiate(gridItemPrefab, gridParent);
                gridItem.GetComponentInChildren<TextMeshProUGUI>().text =
                    russianAlphabet[Random.Range(0, russianAlphabet.Length)].ToString();
                gridItems.Add(gridItem);
            }
        }
    }

    void PlaceWordsInGrid()
    {
        foreach (WordPosition wordPos in wordsToPlace)
        {
            PlaceWord(wordPos);
        }
    }

    void PlaceWord(WordPosition wordPos)
    {
        string word = wordPos.word;
        int startX = wordPos.startX;
        int startY = wordPos.startY;

        if (wordPos.isHorizontal)
        {
            // �������������� ����������
            for (int i = 0; i < word.Length; i++)
            {
                if (startX + i < gridWidth)
                {
                    grid[startX + i, startY] = word[i];
                }
            }
        }
        else
        {
            // ������������ ����������
            for (int i = 0; i < word.Length; i++)
            {
                if (startY + i < gridHeight)
                {
                    grid[startX, startY + i] = word[i];
                }
            }
        }

        UpdateGridUI();
    }

    void UpdateGridUI()
    {
        for (int y = 0; y < gridHeight; y++)
        {
            for (int x = 0; x < gridWidth; x++)
            {
                int index = y * gridWidth + x;
                if (grid[x, y] != '\0')
                {
                    gridItems[index].GetComponentInChildren<TextMeshProUGUI>().text = grid[x, y].ToString();
                }
            }
        }
    }

    public void CheckWord()
    {
        string selectedWord = "";
        foreach (GridItem item in GridItem.hoveredItems)
        {
            selectedWord += item.GetCharacter();
        }
        Debug.Log(selectedWord);

        bool wordFound = false;

        foreach (WordPosition wordPos in wordsToPlace)
        {
            if (wordPos.word == selectedWord && !foundWords.Contains(selectedWord))
            {
                wordFound = true;
                foundWords.Add(selectedWord);
                break;
            }
        }

        if (wordFound)
        {
            foreach (GridItem item in GridItem.hoveredItems)
            {
                item.ChangeColor(Color.green);
                item.isLocked = true; // ����������� ��������� �����
            }
        }
        else
        {
            foreach (GridItem item in GridItem.hoveredItems)
            {
                if (!item.isLocked)
                {
                    item.ChangeColor(item.GetComponentInChildren<Image>().color);
                }
            }
        }

        GridItem.hoveredItems.Clear();

        // ��������, ������� �� ��� �����
        if (foundWords.Count == wordsToPlace.Count)
        {
            SceneManager.LoadScene("Scene_10");
        }
    }
}
