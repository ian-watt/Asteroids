using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject bullet;
    [SerializeField] ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider bullet)
    {

        Instantiate(explosion, gameObject.transform.position, explosion.transform.rotation);
        explosion.Play();
        Destroy(gameObject);
        Destroy(bullet.gameObject);
        Instantiate(audioSource, audioSource.transform.position, audioSource.transform.rotation);
        if(bullet && bullet.transform.name != "Player1")
        {
            KeepScore.Score += 100;
        }
    }
}
