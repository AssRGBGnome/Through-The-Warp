using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyonload_to : MonoBehaviour
{
    private void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("music");
        Destroy(A);
    }
}
