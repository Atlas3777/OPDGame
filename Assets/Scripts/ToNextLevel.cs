using UnityEngine;
using UnityEngine.SceneManagement;
using static GlobasVar;

[AddComponentMenu("My components/ToNextLevel")]
public class ToNextLevel : MonoBehaviour
{
    [Header("������ �����")]
    [SerializeField] public int _sceneIndex;
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

            Save.SaveData(_sceneIndex, directionEntry);
            SceneManager.LoadScene(_sceneIndex);
            
        }
    }

    void SaveScene() {
        FileReader.Write("save.txt", "scam");
        FileReader.Write("save.txt", directionEntry.ToString());
    }
}