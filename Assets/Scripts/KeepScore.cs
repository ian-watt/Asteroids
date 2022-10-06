using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int Score = 0;
    public AudioSource killscore1;
    public AudioSource killscore2;
    public AudioSource killscore3;
    public AudioSource killscore4;
    public AudioSource killscore5;
    public AudioSource thrusters;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Score == 1000)
        {
            killscore1.Play();
        }
        if (Score == 2000)
        {
            killscore2.Play();
        }
        if (Score == 5000)
        {
            killscore3.Play();
        }
        if (Score == 7500)
        {
            killscore4.Play();
        }
        if (Score == 10000)
        {
            killscore5.Play();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            thrusters.Play();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            thrusters.Stop();
        }
    }
    private void OnGUI()
    {
        GUI.TextField(new Rect(100, 50, 100, 25), "Score: " + Score);

    }
}
