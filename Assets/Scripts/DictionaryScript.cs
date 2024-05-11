using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DictionaryScript : MonoBehaviour
{
    public void TriggerOpen() {
        GetComponent<BoxCollider>().isTrigger = true;
    }
}
