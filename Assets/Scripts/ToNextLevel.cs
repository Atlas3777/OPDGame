using UnityEngine;
using UnityEngine.SceneManagement;
using static GlobasVar;

[AddComponentMenu("My components/ToNextLevel")]
public class ToNextLevel : MonoBehaviour
{
    [Header("������ �����")]
    [SerializeField] public string _sceneName;
    [SerializeField] Direction direction;
    

    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == ("Player"))
        {
            if (direction == Direction.Left)
                directionEntry = Direction.Right;
            if (direction == Direction.Right)
                directionEntry = Direction.Left;
            if (direction == Direction.Up)
                directionEntry = Direction.Down;
            if (direction == Direction.Down)
                directionEntry = Direction.Up;

            Save.SaveData(_sceneName, directionEntry);
            SceneManager.LoadScene(_sceneName);
            
        }
    }

    void SaveScene() {
        FileReader.Write("save.txt", "scam");
        FileReader.Write("save.txt", directionEntry.ToString());
    }
}