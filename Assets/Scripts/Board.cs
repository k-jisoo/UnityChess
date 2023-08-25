using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Board : MonoBehaviour
{
    Vector3 mouseTrans;

    int posX = -1, posY = -1;

    private void Start()
    {
        Init();
    }

    void Init() 
    {
        posX = int.Parse(gameObject.name.Substring(0, 1));
        posY = int.Parse(gameObject.name.Substring(1, 1));
    }

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name);
    }
}
