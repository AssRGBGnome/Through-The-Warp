using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen_Menu : MonoBehaviour
{
    private void Start()
    {
        Debug.developerConsoleVisible = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }
}