using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EasterEgg3 : MonoBehaviour
{
    public GameObject Player;
    public GameObject NextLevel_1;
    public GameObject NextLevel_2;
    public GameObject NextLevel_3;
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
        if (other.gameObject == NextLevel_1)
        {
            SceneManager.LoadScene(23);
        }
        if (other.gameObject == NextLevel_2)
        {
            SceneManager.LoadScene(17);
        }
        if (other.gameObject == NextLevel_3)
        {
            SceneManager.LoadScene(22);
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
            Mouse_Lock = false;
        }
    }
}
