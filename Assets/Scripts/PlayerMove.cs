using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed = 5;
    [SerializeField] GameObject floor;
    //TODO: довавить Offset x/y
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            var newPosition = transform.position + new Vector3(0, 0, 1) * _speed * Time.deltaTime;
            newPosition.z = Mathf.Clamp(newPosition.z, -floor.transform.localScale.z/2, floor.transform.localScale.z / 2);      
            transform.position = newPosition;
        }
            

        if (Input.GetKey(KeyCode.S))
        {
            var newPosition = transform.position + new Vector3(0, 0, -1) * _speed * Time.deltaTime;
            newPosition.z = Mathf.Clamp(newPosition.z, -floor.transform.localScale.z / 2, floor.transform.localScale.z / 2);
            transform.position = newPosition;
        }
            
        if (Input.GetKey(KeyCode.A))
        {
            var newPosition = transform.position + new Vector3(-1, 0, 0) * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -floor.transform.localScale.x / 2, floor.transform.localScale.x / 2);      
            transform.position = newPosition;
        }


        if (Input.GetKey(KeyCode.D))
        {
            var newPosition = transform.position + new Vector3(1, 0, 0) * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -floor.transform.localScale.x / 2, floor.transform.localScale.x / 2);
            transform.position = newPosition;
        }
    }
}
