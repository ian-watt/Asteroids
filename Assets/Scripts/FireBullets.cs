using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 0.1F;
    private float nextFire = 0.0F;
    public float bulletVelocity = 50.0f;

    private void Start()
    {

    }
    void Update()
    {
        //Instantiate bullets on either side of ship when LMB is held down
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * bulletVelocity;
        }
    }
}
