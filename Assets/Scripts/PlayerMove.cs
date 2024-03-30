using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            var newPosition = transform.position + new Vector3(0, 0, 1) * _speed * Time.deltaTime;
            newPosition.z = Mathf.Clamp(newPosition.z, -7.5f, 7.5f);      
            transform.position = newPosition;
        }
            

        if (Input.GetKey(KeyCode.S))
        {
            var newPosition = transform.position + new Vector3(0, 0, -1) * _speed * Time.deltaTime;
            newPosition.z = Mathf.Clamp(newPosition.z, -7.5f, 7.5f);
            transform.position = newPosition;
        }
            
        if (Input.GetKey(KeyCode.A))
        {
            var newPosition = transform.position + new Vector3(-1, 0, 0) * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -9.5f, 9.5f);      
            transform.position = newPosition;
        }


        if (Input.GetKey(KeyCode.D))
        {
            var newPosition = transform.position + new Vector3(1, 0, 0) * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -9.5f, 9.5f);
            transform.position = newPosition;
        }
    }
}
