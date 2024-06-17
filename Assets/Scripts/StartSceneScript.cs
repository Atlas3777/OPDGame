using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneScript : MonoBehaviour
{
    public Transform SpawnPositionLeft;
    public Transform SpawnPositionRight;
    public Transform SpawnPositionDown;
    public Transform SpawnPositionUp;


    // Start is called before the first frame update
    void Start()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        if(GlobasVar.directionEntry == GlobasVar.Direction.Right)
            player.transform.position = SpawnPositionRight.transform.position;
        if (GlobasVar.directionEntry == GlobasVar.Direction.Left)
            player.transform.position = SpawnPositionLeft.transform.position;
        if (GlobasVar.directionEntry == GlobasVar.Direction.Up)
            player.transform.position = SpawnPositionUp.transform.position;
        if (GlobasVar.directionEntry == GlobasVar.Direction.Down)
            player.transform.position = SpawnPositionDown.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
