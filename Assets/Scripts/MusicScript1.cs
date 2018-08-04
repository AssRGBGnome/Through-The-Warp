using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript1 : MonoBehaviour
{
    public AudioSource Audiosource;
    public bool on = true;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if(on == true)
            {
                AudioListener.volume = 0f;
                on = false;
            }
            else
            {
                AudioListener.volume = 1f;
                on = true;
            }
        }
    }

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
}
