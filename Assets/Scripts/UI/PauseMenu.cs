using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

//Used this video to help code this (https://www.youtube.com/watch?v=MNUYe0PWNNs&t=182s)
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject OPTIONS;

    AudioManager AudioManager;
    
    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void Pause()
    {
        pauseMenu.SetActive(true); //when the button is clicked it activates it 
        AudioManager.PlaySFX(AudioManager.Button);
        Time.timeScale = 0; //pauses game
    }

    public void Options()
    {
        OPTIONS.SetActive(true); //when the button is clicked it activates it 
        AudioManager.PlaySFX(AudioManager.Button);
        Time.timeScale = 0; //pauses game
    }

        public void Close()
    {
        OPTIONS.SetActive(false);
        pauseMenu.SetActive(true); //when the button is clicked it activates it 
        AudioManager.PlaySFX(AudioManager.Button);
        Time.timeScale = 0; //pauses game
    }



    public void Home()
    {
        SceneManager.LoadScene("MainMenu"); //will load the scene called MainMenu on click
        AudioManager.PlaySFX(AudioManager.Button);
        Time.timeScale = 1; //resumes the game
    }

    public void Resume()
    {
        pauseMenu.SetActive(false); // on click closes the pause menu
        AudioManager.PlaySFX(AudioManager.Button);
        Time.timeScale = 1; //resumes the game
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //relaods the scene on click
        AudioManager.PlaySFX(AudioManager.Button);
        Time.timeScale = 1; //resumes the game
    }
}
