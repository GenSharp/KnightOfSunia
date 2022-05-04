using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject pause;
    private bool isPaused;
    public bool usingPause;
    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        pause.SetActive(false);
        usingPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangePause();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangePause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            pause.SetActive(true);
            Time.timeScale = 0f;
            usingPause = true;
        }

        else
        {
            pause.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
