using System;
using UnityEngine;

public class GlobasVar : MonoBehaviour
{
    [Serializable]
    public enum Direction
    {
        Up,
        Right,
        Down,
        Left,
    }

    public static Direction directionEntry;

    
}
