using UnityEngine;

public class DictionaryScript : MonoBehaviour
{
    public void TriggerOpen() {
        GetComponent<BoxCollider>().isTrigger = true;
    }
}
