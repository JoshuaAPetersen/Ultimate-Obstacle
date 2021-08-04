using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    [SerializeField] KeyCode Menu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Menu))
        SceneManager.LoadScene("MainMenu");
    }
}
