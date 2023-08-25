using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;

public class Board : MonoBehaviour, IPointerDownHandler
{
    int posX = -1, posY = -1;

    private void Start()
    {
        Init();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(posX);
        Debug.Log(posY);
    }

    void Init() 
    {
        posX = int.Parse(gameObject.name.Substring(0, 1));
        posY = int.Parse(gameObject.name.Substring(1, 1));
    }

}
