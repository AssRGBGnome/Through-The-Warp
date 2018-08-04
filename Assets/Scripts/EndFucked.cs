using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFucked : MonoBehaviour
{
    public GameObject End;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == End)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}