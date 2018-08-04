using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EasterEgg1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Key_1;
    public GameObject Key_2;
    public GameObject Downwell;
    public GameObject NextLevel;
    public int count;
    public GameObject Menu;
    public TextMeshProUGUI deathcounter_Text;
    public bool Mouse_Lock = true;

    private void Update()
    {
        deathcounter_Text.text = "Death count : " + DeathcounterClass.Score.TotalDeaths.ToString();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Pause();
        }
        if (Mouse_Lock == true)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Key_1)
        {
            Key_1.SetActive(false);
            count += 1;
        }
        if (other.gameObject == Key_2)
        {
            Key_2.SetActive(false);
            count += 1;
        }
        if(count >= 2)
        {
            Downwell.SetActive(false);
        }
        if (other.gameObject == NextLevel)
        {
            SceneManager.LoadScene(9);
        }
    }

    void Pause()
    {
        if (Menu.gameObject.activeInHierarchy == false)
        {
            Menu.gameObject.SetActive(true);
            Time.timeScale = 0;
            Mouse_Lock = false;
        }

        else
        {
            Menu.gameObject.SetActive(false);
            Time.timeScale = 1;
            Mouse_Lock = true;
        }
    }
}