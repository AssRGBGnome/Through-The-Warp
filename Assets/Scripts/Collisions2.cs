using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Collisions2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Key_1;
    public GameObject Gate_1;
    public GameObject NextLevel;
    public bool death = false;
    public float timeLeft = .8f;
    private int level = 2;
    public Animator anim;
    public Rigidbody2D rbtwod;
    public Rigidbody2D enemy;
    public EnemyAI_1 eai1;
    public GameObject Menu;
    public TextMeshProUGUI deathcounter_Text;
    public bool Mouse_Lock = true;

    private void Update()
    {
        if (Mouse_Lock == true)
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Pause();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
        deathcounter_Text.text = "Death count : " + DeathcounterClass.Score.TotalDeaths.ToString();

        if (death == true)
        {
            rbtwod.constraints = RigidbodyConstraints2D.FreezeAll;
            eai1.Enemy_1.disable();
            enemy.constraints = RigidbodyConstraints2D.FreezeAll;
            anim.SetBool("dead", true);
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                DeathcounterClass.Score.IncrementDeaths(level);
                SceneManager.LoadScene(2);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == Key_1)
        {
            Key_1.SetActive(false);
            Gate_1.SetActive(false);
        }
        if(other.gameObject.tag == "Death")
        {
            death = true;
        }
        if(other.gameObject == NextLevel)
        {
            SceneManager.LoadScene(3);
        }
    }

    void Pause()
    {
        if (Menu.gameObject.activeInHierarchy == false)
        {
            Menu.gameObject.SetActive(true);
            Time.timeScale = 0;
            enemy.constraints = RigidbodyConstraints2D.FreezeAll;
            eai1.enabled = false;
            Mouse_Lock = false;
        }

        else
        {
            Time.timeScale = 1;
            Menu.gameObject.SetActive(false);
            enemy.constraints = RigidbodyConstraints2D.None;
            eai1.enabled = true;
            Mouse_Lock = true;
        }
    }
}