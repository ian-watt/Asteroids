using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSplit : MonoBehaviour
{
    public AudioSource audioSource;
    private float asteroidVelocity;
    public GameObject bullet;
    [SerializeField] ParticleSystem explosion;
    public GameObject miniAsteroids;
    void Start()
    {
        asteroidVelocity = Random.Range(10, 20);
        audioSource.enabled = true;

    }

    void OnTriggerEnter(Collider bullet)
    {
 
        Instantiate(explosion, gameObject.transform.position, explosion.transform.rotation);
        explosion.Play();
        Destroy(gameObject);
        Destroy(bullet.gameObject);
        GameObject miniAsteroid1 = Instantiate(miniAsteroids, gameObject.transform.position, Quaternion.Euler(Random.Range(0,360), Random.Range(0,360), Random.Range(0,360)));
        Rigidbody rb1 = miniAsteroid1.GetComponent<Rigidbody>();
        rb1.velocity = transform.forward * asteroidVelocity;
        GameObject miniAsteroid2 = Instantiate(miniAsteroids, gameObject.transform.position, Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
        Rigidbody rb2 = miniAsteroid2.GetComponent<Rigidbody>();
        rb2.velocity = transform.right * asteroidVelocity;
        GameObject miniAsteroid3 = Instantiate(miniAsteroids, gameObject.transform.position, Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
        Rigidbody rb3 = miniAsteroid3.GetComponent<Rigidbody>();
        rb3.velocity = transform.forward * asteroidVelocity;
        Instantiate(audioSource, audioSource.transform.position, audioSource.transform.rotation);
        if (bullet && bullet.transform.name != "Player1")
        {
            KeepScore.Score += 100;
        }
    }
}

