using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // bool levelHasEnded = false;
    public float delay = 1f;

    public void RestartLevel()
    {
        // if (levelHasEnded == false)
        // {
        //     // levelHasEnded = true;
        //     // Debug.Log("restart level");
        //     // Invoke("LoadSameLevel", delay);
        // }
        Debug.Log("loading restart level");
        Invoke("LoadSameLevel", delay);
    }

    public void NextLevel()
    {
        Debug.Log(" loading next level");
        Invoke("LoadNextLevel", delay);
    }

    void LoadSameLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
