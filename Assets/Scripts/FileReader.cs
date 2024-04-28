using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class FileReader : MonoBehaviour
{
    public static Dictionary<string, bool> Termins { get; private set; }
    public static string filePath;

    public FileReader()
    {
        filePath = Application.dataPath + "/example.txt";
    }

    public static void Read()
    {
        filePath = Application.dataPath + "/example.txt";
        //���������, ���������� �� ����
        if (File.Exists(filePath))
        {
            // ������ ����� �� �����
            string fileContent = File.ReadAllText(filePath);
            Debug.Log("���������� �����: " + fileContent);
        }
        else
        {
            Debug.LogError("���� �� ������!");
        }

        
    }
    public static void Write(string text)
    {
        filePath = Application.dataPath + "/example.txt";
        File.AppendAllText(filePath, text + "\n");

        Debug.Log("���� ������� �������!");

    }
}
