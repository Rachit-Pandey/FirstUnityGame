﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonHandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
