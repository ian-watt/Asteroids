using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffCameraObjects : MonoBehaviour
{
    void OnBecameInvisible()
    {
        float radius = new Vector3(39, 0, 23).magnitude;
        if (transform.position.magnitude > radius)
        {
            Destroy(gameObject);
        }
    }
}