using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PhotonTest : MonoBehaviourPunCallbacks
{
    public InputField m_InputField;
    public Text m_textConnectLog;
    public Text m_textPlayerList;

    void Start()
    {
        Screen.SetResolution(960, 600, false);

        m_textConnectLog.text = "접속로그\n";
    }

    public override void OnConnectedToMaster()
    {
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 2;

        PhotonNetwork.LocalPlayer.NickName = m_InputField.text;
        PhotonNetwork.JoinOrCreateRoom("Room1", options, null);

        Debug.Log("OnConnectedToMaster");
    }
    public override void OnJoinedRoom()
    {
        updatePlayer();
        m_textConnectLog.text += m_InputField.text;
        m_textConnectLog.text += " 님이 방에 참가하였습니다.\n";

        Debug.Log("OnJoinedRoom");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        updatePlayer();
        m_textConnectLog.text += newPlayer.NickName;
        m_textConnectLog.text += " 님이 입장하였습니다.\n";

        Debug.Log("OnPlayerEnteredRoom");
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        updatePlayer();
        m_textConnectLog.text += otherPlayer.NickName;
        m_textConnectLog.text += " 님이 퇴장하였습니다.\n";

        Debug.Log("OnPlayerLeftRoom");
    }

    public void Connect()
    {
        PhotonNetwork.ConnectUsingSettings();

        Debug.Log("Connect");
    }

    void updatePlayer()
    {
        m_textPlayerList.text = "접속자";
        for (int i = 0; i < PhotonNetwork.PlayerList.Length; i++)
        {
            m_textPlayerList.text += "\n";
            m_textPlayerList.text += PhotonNetwork.PlayerList[i].NickName;
        }

        Debug.Log("updatePlayer");
    }

}