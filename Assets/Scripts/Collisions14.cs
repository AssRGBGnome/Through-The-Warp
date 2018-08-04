using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Collisions14 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Key_1;
    public GameObject Key_2;
    public GameObject Key_3;
    public GameObject Gate_1;
    public GameObject NextLevel;
    public int count;
    public bool death = false;
    public float timeLeft = .8f;
    private int level = 14;
    public Animator anim;
    public Animator lazer2;
    public Rigidbody2D rbtwod;
    public Rigidbody2D[] enemy;
    public EnemyAI_12 eai12;
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
            lazer2.enabled = false;
            eai12.Enemy_1.disable();
            eai12.Enemy_2.disable();
            eai12.Enemy_3.disable();
            eai12.Enemy_4.disable();
            enemy[0].constraints = RigidbodyConstraints2D.FreezeAll;
            enemy[1].constraints = RigidbodyConstraints2D.FreezeAll;
            enemy[2].constraints = RigidbodyConstraints2D.FreezeAll;
            enemy[3].constraints = RigidbodyConstraints2D.FreezeAll;
            anim.SetBool("dead", true);
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                DeathcounterClass.Score.IncrementDeaths(level);
                SceneManager.LoadScene(14);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == Key_1)
        {
            count += 1;
            Key_1.SetActive(false);
        }
        if(other.gameObject == Key_2)
        {
            count += 1;
            Key_2.SetActive(false);
        }
        if (other.gameObject == Key_3)
        {
            count += 1;
            Key_3.SetActive(false);
        }
        if (count >= 3)
        {
            Gate_1.SetActive(false);
        }
        if (other.gameObject.tag == "Death")
        {
            death = true;
        }
        if(other.gameObject == NextLevel)
        {
            SceneManager.LoadScene(15);
        }
    }

    void Pause()
    {
        if (Menu.gameObject.activeInHierarchy == false)
        {
            Menu.gameObject.SetActive(true);
            Time.timeScale = 0;
            enemy[0].constraints = RigidbodyConstraints2D.FreezeAll;
            enemy[1].constraints = RigidbodyConstraints2D.FreezeAll;
            enemy[2].constraints = RigidbodyConstraints2D.FreezeAll;
            enemy[3].constraints = RigidbodyConstraints2D.FreezeAll;
            eai12.enabled = false;
            Mouse_Lock = false;
        }

        else
        {
            Menu.gameObject.SetActive(false);
            Time.timeScale = 1;
            enemy[0].constraints = RigidbodyConstraints2D.None;
            enemy[1].constraints = RigidbodyConstraints2D.None;
            enemy[2].constraints = RigidbodyConstraints2D.None;
            enemy[3].constraints = RigidbodyConstraints2D.None;
            eai12.enabled = true;
            Mouse_Lock = false;
        }
    }
}