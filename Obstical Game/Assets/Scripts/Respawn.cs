using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform player;
    public Vector3 spawnPoint;
    [SerializeField] string strTag;

    void Start(){
        spawnPoint = new Vector3 (0,1,-5);
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == strTag){
        player.transform.position = spawnPoint;
        }
    }
    
    public void SetSpawn(Vector3 newPosition){
        spawnPoint = newPosition;
    }

}
