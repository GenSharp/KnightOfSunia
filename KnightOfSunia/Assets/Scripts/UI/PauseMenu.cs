using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private bool isPaused;
    public GameObject pause;
    public bool usingPause;

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
