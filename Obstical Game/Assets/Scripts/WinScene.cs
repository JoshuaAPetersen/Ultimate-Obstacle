using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    public void Next(){
        SceneManager.LoadScene("2PlayerLevel2");
    }
    public void Menu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
