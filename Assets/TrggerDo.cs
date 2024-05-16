using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrggerDo : MonoBehaviour
{
    [SerializeField] public UnityEvent unityAction;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            unityAction.Invoke();
        }
    }
}
