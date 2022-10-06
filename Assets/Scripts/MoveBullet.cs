using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        //move bullet forward
        rb.transform.position += rb.transform.forward * Time.deltaTime * speed;
    }
}
