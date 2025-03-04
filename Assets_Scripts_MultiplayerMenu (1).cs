using UnityEngine;
using UnityEngine.UI;

public class MultiplayerMenu : MonoBehaviour
{
    public InputField roomNameInputField;

    public void OnCreateRoomButtonClicked()
    {
        String roomName = roomNameInputField.text;
        if (!String.IsNullOrEmpty(roomName))
        {
            MultiplayerManager.instance.CreateRoom(roomName);
        }
    }

    public void OnJoinRoomButtonClicked()
    {
        String roomName = roomNameInputField.text;
        if (!String.IsNullOrEmpty(roomName))
        {
            MultiplayerManager.instance.JoinRoom(roomName);
        }
    }
}