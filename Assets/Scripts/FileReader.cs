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

    // public static List<string> Read(string fileName)
    // {
    //     fileName = Application.dataPath +"/Saves/"+ fileName;
    //     if (File.Exists(fileName))
    //     {
    //         string[] fileContent = File.ReadAllLines(fileName);
    //         return fileContent.ToList();
    //     }
    //     else
    //     {
    //         Debug.LogError("Error!");
    //         return new List<string>();
    //     }


    // }
    // public static void Write(string fileName, string text)
    // {
    //     fileName = Application.dataPath +"/Saves/"+ fileName;
    //     File.AppendAllText(fileName, text + "\n");

    //     Debug.Log("Write!");

    // }

    public static void Clear(string fileName)
    {
        fileName = Application.dataPath + "/Saves/" + fileName + ".txt";
        File.WriteAllText(fileName, string.Empty);
    }

    public static void Write(string fileName, string text)
    {
        Debug.Log("Write");
        string path = Application.dataPath + "/Saves/" + fileName;
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(text);
        writer.Close();
        Debug.Log("Write!");
    }
   public static List<string> Read(string fileName)
   {
       string path = Application.dataPath + "/Saves/" + fileName;
       //Read the text from directly from the test.txt file
       StreamReader reader = new StreamReader(path);
       var str = reader.ReadToEnd();
       Debug.Log(str);
       string[] strings = str.Split('\n');   
       foreach (var str1 in strings) {
        Debug.Log(str1);
       }
       reader.Close();
       return strings.ToList();
   }

//    public static void Clear(string fileName)
//     {
//         fileName = Application.dataPath + "/Saves/" + fileName + ".txt";
//         StreamReader writer = new StreamReader(fileName);
//         writer.;
//         writer.Close();
//     }

}