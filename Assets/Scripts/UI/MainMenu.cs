using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Watched video (https://www.youtube.com/watch?v=DX7HyN7oJjE) to create main menu 
public class MainMenu : MonoBehaviour
{
    AudioManagerMainMenu AudioManagerMainMenu;

     private void Awake()
    {
        AudioManagerMainMenu = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerMainMenu>();
    }

    public void playGame()
    {
        AudioManagerMainMenu.PlaySFX(AudioManagerMainMenu.PlayButton);
        SceneManager.LoadSceneAsync(1); //this will load the next scene
    }

    public void QuitGame()
    {
        AudioManagerMainMenu.PlaySFX(AudioManagerMainMenu.Button);
        Application.Quit(); // this will close the game
    }     
    
}
