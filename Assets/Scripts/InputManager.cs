using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D[] hit = Physics2D.RaycastAll(ray.origin, transform.up, 100f);
            Debug.DrawLine(ray.origin, transform.up, Color.red, 10f);
            for(int i = 0; i < hit.Length; i++)
                Debug.Log(hit[i].collider.gameObject.name);
        }
    }
}
