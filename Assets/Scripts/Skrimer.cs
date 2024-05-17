using UnityEngine;

public class Skrimer : MonoBehaviour
{
    [SerializeField] float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;

        transform.eulerAngles += new Vector3(0, 0, 10) * Time.deltaTime;
    }
}
