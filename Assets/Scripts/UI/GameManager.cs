using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// i learned how to code3 this from (https://www.youtube.com/watch?v=pKFtyaAPzYo)
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;

    AudioManager AudioManager;

    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
         Time.timeScale = 0;
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu"); //will load the scene called MainMenu on click
        AudioManager.PlaySFX(AudioManager.Button);
        Time.timeScale = 1; //resumes the game
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        AudioManager.PlaySFX(AudioManager.Button);
        Time.timeScale = 1;

    }

    public void quit()
    {
        Application.Quit();
        AudioManager.PlaySFX(AudioManager.Button);
    }
}
