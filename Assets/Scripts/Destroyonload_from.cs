using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyonload_from : MonoBehaviour
{
    private void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("Music");
        Destroy(A);
    }
}