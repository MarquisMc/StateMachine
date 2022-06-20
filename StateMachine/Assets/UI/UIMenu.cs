using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public void LoadLevel(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
        Debug.Log(LevelName);
    }

    public void QuitApplication()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
