using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    #region ΩÃ±€≈Ê
    public static BoardManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }

        if (instance != this)
            Destroy(this.gameObject);

    }
    #endregion

    public Board[] boards;

    const int boardNum = 64;

    // Start is called before the first frame update
    void Start()
    {
        SetBoards();
    }

    void SetBoards()
    {
        boards = new Board[boardNum];

        for (int i = 0; i < boards.Length; i++)
        {
            boards[i] = transform.GetChild(i).GetComponent<Board>();
        }
    }

    public int GetColFromPosition(float x)
    {
        return (int)(x + 3.5);
    }

    public int GetRowFromPosition(float y)
    {
        return (int)Math.Abs(y - 3.5);
    }

    public void ShowMovableMap()
    {

    }
}
