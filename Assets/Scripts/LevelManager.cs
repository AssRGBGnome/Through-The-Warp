using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(1);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene(2);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(3);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(4);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(5);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene(6);
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene(7);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene(8);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene(9);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(10);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(11);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(12);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene(13);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(14);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(15);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene(16);
        }
    }
}