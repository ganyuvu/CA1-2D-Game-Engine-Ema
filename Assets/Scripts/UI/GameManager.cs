using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// i learned how to code3 this from (https://www.youtube.com/watch?v=pKFtyaAPzYo)
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;


    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void quit()
    {
        Application.Quit();
    }
}
