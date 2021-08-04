using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoll : MonoBehaviour
{
    public float speed = 2;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        float moveH = Input.GetAxis("Horizontal1");
        float moveV = Input.GetAxis("Vertical1");
        Vector3 movement = new Vector3 (moveH, 0f, moveV);
        rb.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
