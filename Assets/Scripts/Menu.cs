using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    public void StartGame()
    {
        SceneManager.LoadScene ("Main");
        ResumeGame();
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Button was pressed");
    }
    
}
