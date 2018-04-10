using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;
    private GameManagerScript GMS;

	void Start ()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
	}
	
	void Update ()
    {
		
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                if (GameisPaused)
                    Resume();
                else
                    Pause();
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game !");
        Application.Quit();
    }
}
