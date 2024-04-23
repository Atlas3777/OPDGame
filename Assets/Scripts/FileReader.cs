using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class FileReader : MonoBehaviour
{
    public static Dictionary<string, bool> Termins { get; private set; }

    public static void Read()
    {
        string filePath = Application.dataPath + "/example.txt";

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
        string filePath = Application.dataPath + "/example.txt";
       

        //// ���������� ����� � ����
        File.WriteAllText(filePath, text);

        Debug.Log("���� ������� �������!");


    }
}
