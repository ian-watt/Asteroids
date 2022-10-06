using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int sceneID;
    public void ButtonScene()
    {
        StartCoroutine(Example());
        IEnumerator Example()
        {
            KeepScore.Score = 0;
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(sceneID);
        }
    }
}