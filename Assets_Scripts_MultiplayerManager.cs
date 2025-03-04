using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerManager : MonoBehaviourPunCallbacks
{
    public static MultiplayerManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby");
        // Navigate to multiplayer menu scene
        SceneManager.LoadScene("MultiplayerMenu");
    }

    public void CreateRoom(string roomName)
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;
        PhotonNetwork.CreateRoom(roomName, roomOptions);
    }

    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room");
        // Load the game scene
        SceneManager.LoadScene("GameScene");
    }

    public override void OnCreateRoomFailed(short returnCode, String message)
    {
        Debug.LogError("Create Room Failed: " + message);
    }

    public override void OnJoinRoomFailed(short returnCode, String message)
    {
        Debug.LogError("Join Room Failed: " + message);
    }
}