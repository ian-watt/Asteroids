using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonEffect : MonoBehaviour
{

    public AudioSource audioSource;
    // Start is called before the first frame update
    public void PlayButtonSoundEffect()
    {
        audioSource.Play();
    }
}
