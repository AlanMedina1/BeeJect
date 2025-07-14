using UnityEngine;

//this scene is for a panel of pause for a game.


public class PauseMenu: MonoBehaviour
{

    public GameObject pausemenupanel;

    public void TogglePause()
    {
         bool isActive = pausemenupanel.activeSelf;
    Debug.Log("TogglePause called. Current state: " + isActive);

    pausemenupanel.SetActive(!isActive);

    if (!isActive)
    {
        Time.timeScale = 0f;
        Debug.Log("Game paused.");
    }
    else
    {
        Time.timeScale = 1f;
        Debug.Log("Game resumed.");
    }
    }
}
