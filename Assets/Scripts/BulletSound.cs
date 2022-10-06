using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSound : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioSource.Play();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            audioSource.Stop();
        }
    }
}
