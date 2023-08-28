using UnityEngine;

public class PlayerState : MonoBehaviour
{
    #region �̱��� ����
    public static PlayerState instance = null;

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
    public bool turn = false;
    public bool isClicked = false;
    public GameObject clickedBoard;
    public GameObject clickedPiece;
}
