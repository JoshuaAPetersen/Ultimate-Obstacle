using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Respawn theRespawn;
    // Start is called before the first frame update
    void Start()
    {
        theRespawn = FindObjectOfType<Respawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            theRespawn.SetSpawn(transform.position);
        }
    }
}
