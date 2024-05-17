using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class FileReader : MonoBehaviour
{
    public static Dictionary<string, bool> Termins { get; private set; }
    public static string filePathLogbook;
    public static string filePathSave;

    void Start()
    {
        filePathLogbook = Application.dataPath + "/example.txt";
        filePathSave = Application.dataPath + "/save.txt";
    }

    public static List<string> Read(string fileName)
    {
        fileName = Application.dataPath +"/Saves/"+ fileName;
        if (File.Exists(fileName))
        {
            string[] fileContent = File.ReadAllLines(fileName);
            return fileContent.ToList();
        }
        else
        {
            Debug.LogError("Error!");
            return new List<string>();
        }


    }
    public static void Write(string fileName, string text)
    {
        fileName = Application.dataPath +"/Saves/"+ fileName;
        File.AppendAllText(fileName, text + "\n");

        Debug.Log("Write!");

    }

    public static void Cleer(string fileName)
    {
        fileName = Application.dataPath + "/Saves/" + fileName;
        File.WriteAllText(fileName, string.Empty);
    }
}