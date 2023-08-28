using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Piece : MonoBehaviour
{
    public int row;
    public int col;

    public enum Team
    {
        Black,
        White,
    }
    public Team team;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        InitPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitPos()
    {
        row = BoardManager.instance.GetRowFromPosition(gameObject.transform.position.y);
        col = BoardManager.instance.GetColFromPosition(gameObject.transform.position.x);
    }

    public abstract bool IsMovable(int posX, int posY);
}
