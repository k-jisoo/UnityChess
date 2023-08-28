using UnityEngine;

public class PlayerState : MonoBehaviour
{
    #region ½Ì±ÛÅæ ¼±¾ð
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
