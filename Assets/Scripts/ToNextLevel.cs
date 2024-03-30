using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[AddComponentMenu("My components/ToNextLevel")]
public class ToNextLevel : MonoBehaviour
{
    [Header("Индекс сцены")]
    public int _sceneIndex;

    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == ("Player"))
        {
            SceneManager.LoadScene(_sceneIndex);
        }
    }
}