using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float rotateSpeed = 10f;
    public Rigidbody rb;
    public float maxVelocity = 5f;
    public float acceleration = 5f;
    public float moveSpeedDecay = 1;
    [SerializeField] ParticleSystem explosion;
    public Rigidbody[] asteroid;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public int sceneID;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        //rotation
        rb.rotation *= Quaternion.AngleAxis(Time.deltaTime * rotateSpeed * Input.GetAxis("Horizontal"), Vector3.up);

        //accelerate forward
        rb.velocity += rb.transform.forward * Input.GetAxis("Vertical") * acceleration * Time.deltaTime;

        //clamp max speed
        if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = Vector3.Normalize(rb.velocity) * maxVelocity;
        }

        //decellerate
        if (Mathf.Abs(Input.GetAxis("Vertical")) < 0.02f && rb.velocity.sqrMagnitude > 0.01f)
        {
            rb.velocity = Vector3.Normalize(rb.velocity) * (rb.velocity.magnitude - moveSpeedDecay * Time.deltaTime);
        }

        //flip position axis if ship goes out of bounds

        //x flip
        if (rb.transform.position.x > 38)
        {
            rb.MovePosition(new Vector3((rb.transform.position.x * -1) + .1f, rb.transform.position.y, rb.transform.position.z));
        }
        if (rb.transform.position.x < -38)
        {
            rb.MovePosition(new Vector3((rb.transform.position.x * -1) - .1f, rb.transform.position.y, rb.transform.position.z));
        }

        //z flip
        if (rb.transform.position.z > 22)
        {
            rb.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y, (rb.transform.position.z * -1) + .1f);
        }
        if (rb.transform.position.z < -22)
        {
            rb.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y, (rb.transform.position.z * -1) - .1f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(explosion, gameObject.transform.position, explosion.transform.rotation);
        explosion.Play();
        Instantiate(audioSource, audioSource.transform.position, audioSource.transform.rotation);
        audioSource2.enabled = false;
    }
}
