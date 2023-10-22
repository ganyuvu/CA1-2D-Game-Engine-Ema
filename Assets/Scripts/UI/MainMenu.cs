using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Watched video (https://www.youtube.com/watch?v=DX7HyN7oJjE) to create main menu 
    public void playGame()
    {
        SceneManager.LoadSceneAsync(1); //this will load the next scene
    }

    public void QuitGame()
    {
        Application.Quit(); // this will close the game
    }     
    
}
