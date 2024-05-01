using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class FileReader : MonoBehaviour
{
    public static Dictionary<string, bool> Termins { get; private set; }
    public static string filePath;

    public FileReader()
    {
        filePath = Application.dataPath + "/example.txt";
    }

    public static List<string> Read()
    {
        filePath = Application.dataPath + "/example.txt";
        //���������, ���������� �� ����
        if (File.Exists(filePath))
        {
            // ������ ����� �� �����
            string[] fileContent = File.ReadAllLines(filePath);
            return fileContent.ToList();
        }
        else
        {
            Debug.LogError("���� �� ������!");
            return new List<string>();
        }

        
    }
    public static void Write(string text)
    {
        filePath = Application.dataPath + "/example.txt";
        File.AppendAllText(filePath, text + "\n");

        Debug.Log("���� ������� �������!");

    }
}
