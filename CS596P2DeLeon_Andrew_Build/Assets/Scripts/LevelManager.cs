using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LaunchLazyFlight()
    {
        SceneManager.LoadScene("LazyFlight");
    }

    public void LaunchFlock()
    {
        SceneManager.LoadScene("Flock");
    }

    public void LaunchQuitGame()
    {
        Application.Quit();
    }
}
