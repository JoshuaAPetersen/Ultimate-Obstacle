using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicConntroller : MonoBehaviour
{

    private static MusicConntroller musicManagerInstance;
    void Awake() 
    {
        DontDestroyOnLoad(transform.gameObject);

        if(musicManagerInstance == null){
            musicManagerInstance = this;
        }else{
            Destroy(gameObject);
        }
    }
}
