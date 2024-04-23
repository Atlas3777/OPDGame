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
        string filePath = Application.dataPath + "/example.txt";
       

        //// Записываем текст в файл
        File.WriteAllText(filePath, text);

        Debug.Log("Файл успешно записан!");


    }
}
