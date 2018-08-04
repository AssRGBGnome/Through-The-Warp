using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManagement : MonoBehaviour
{
    public GameObject EasterEgg;
    public void Play() { SceneManager.LoadScene(1); DeathcounterClass.Score.TotalDeaths = 0; Time.timeScale = 1; }
    public void Credits() { SceneManager.LoadScene(18); }
    public void Exit() { EasterEgg.SetActive(true); }
    public void MainMenu() { SceneManager.LoadScene(0); Time.timeScale = 1; }
    public void CloseMenu() { GameObject.Find("Menu").SetActive(false); Time.timeScale = 1; }
    public void End1() { SceneManager.LoadScene(19); }
    public void End2() { SceneManager.LoadScene(20); }
    public void End3() { SceneManager.LoadScene(21); }
}