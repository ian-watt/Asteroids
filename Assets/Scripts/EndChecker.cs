using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndChecker : MonoBehaviour
{
    public AudioSource audioSource;
    public int sceneID;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.enabled)
        {
            StartCoroutine(Example());
            IEnumerator Example()
            {
                yield return new WaitForSeconds(1.5f);
                SceneManager.LoadScene(sceneID);
            }
        }
    }
}
