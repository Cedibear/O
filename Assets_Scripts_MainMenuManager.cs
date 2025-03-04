using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlaySinglePlayer()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void PlayMultiplayer()
    {
        SceneManager.LoadScene("MultiplayerMenu");
    }

    public void OpenSettings()
    {
        // Load settings scene or display settings UI
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}