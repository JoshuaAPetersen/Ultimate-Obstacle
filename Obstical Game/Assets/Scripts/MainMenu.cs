using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SoloGame(){
        SceneManager.LoadScene("1Player");
    }
    public void CoopGame(){
        SceneManager.LoadScene("2Player");
    }
    public void QuitGame(){
        Debug.Log("QuitGame");
        Application.Quit();
    }
}
