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
        //Проверяем, существует ли файл
        if (File.Exists(filePath))
        {
            // Читаем текст из файла
            string fileContent = File.ReadAllText(filePath);
            Debug.Log("Содержимое файла: " + fileContent);
        }
        else
        {
            Debug.LogError("Файл не найден!");
        }

        
    }
    public static void Write(string text)
    {
        filePath = Application.dataPath + "/example.txt";
        File.AppendAllText(filePath, text + "\n");

        Debug.Log("Файл успешно записан!");

    }
}
