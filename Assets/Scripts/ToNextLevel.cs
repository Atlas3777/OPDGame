using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static GlobasVar;

[AddComponentMenu("My components/ToNextLevel")]
public class ToNextLevel : MonoBehaviour
{
    [Header("Индекс сцены")]
    public int _sceneIndex;
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


            SceneManager.LoadScene(_sceneIndex);
            
        }
    }
}