using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEditor.SearchService;
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
