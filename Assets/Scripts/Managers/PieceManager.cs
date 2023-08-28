using ExitGames.Client.Photon.StructWrapping;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{
    #region ΩÃ±€≈Ê
    public static PieceManager instance = null;

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

    public Piece[] pieces;

    const int pieceNum = 32;

    // Start is called before the first frame update
    void Start()
    {
        SetPieces();
    }

    void SetPieces()
    {
        pieces = new Piece[pieceNum];

        for(int i = 0; i < pieces.Length; i++)
        {
            pieces[i] = transform.GetChild(i).GetComponent<Piece>();
        }
    }

    public GameObject GetPieceFromPos(int posX, int posY)
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            if (pieces[i].col == posY && pieces[i].row == posX)
            {
                UnityEngine.Debug.Log(pieces[i].col);
                return pieces[i].gameObject;
            }
        }

        return null;
    }
}
