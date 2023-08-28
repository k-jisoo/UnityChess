using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Board : MonoBehaviour
{
    public int posX;
    public int posY;

    private void Start()
    {
        InitBoard();
    }

    void InitBoard() 
    {
        posX = int.Parse(gameObject.name.Substring(0, 1));
        posY = int.Parse(gameObject.name.Substring(1, 1));
    }

    private void OnMouseDown()
    {
        if (PlayerState.instance.isClicked == false)
        {
            FirstClickProcess();
        }
        else
        {
            SecondClickProcess();
        }
    }

    bool HasPiece(int posX, int posY)
    {
        if(PieceManager.instance.GetPieceFromPos(posX, posY) == null) 
            return false;
        
        return true;
    }

    void FirstClickProcess()
    {
        if (!this.HasPiece(posX, posY))
            return;

        PlayerState.instance.clickedBoard = this.gameObject;
        PlayerState.instance.clickedPiece = PieceManager.instance.GetPieceFromPos(posX, posY);
        BoardManager.instance.ShowMovableMap();

        PlayerState.instance.isClicked = true;
    }

    void SecondClickProcess()
    {
        //���õ� Board(this)�� SelectedPiece�� MovableBoard���� Ȯ��
        //�´ٸ� �̵�
        //Ʋ�ȴٸ� clicekdBoard�� clickedPiece�� null�� ����� return;

        PlayerState.instance.clickedBoard = null;
        PlayerState.instance.clickedPiece = null;
    }
}
