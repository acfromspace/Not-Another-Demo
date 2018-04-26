using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LaunchLazyFlight()
    {
        SceneManager.LoadScene("Lazy Flight");
    }

    public void LaunchFollowTheLeader()
    {
        SceneManager.LoadScene("Follow the Leader");
    }

    public void LaunchMultiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }

    public void LaunchMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LaunchQuitGame()
    {
        Application.Quit();
    }
}
