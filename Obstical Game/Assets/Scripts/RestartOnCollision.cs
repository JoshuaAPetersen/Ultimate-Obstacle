using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;
    private void OnTriggerEnter(Collider other) {
        if (other.tag == strTag)
        SceneManager.LoadScene("1Player");
    }
}
