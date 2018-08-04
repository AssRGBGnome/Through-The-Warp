using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_10 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy1;
    public GameObject Enemy1_Trigger;
    public GameObject Enemy2;
    public GameObject Enemy2_Trigger;
    public GameObject Enemy3;
    public GameObject Enemy3_Trigger;
    public GameObject Enemy4;
    public GameObject Enemy4_Trigger;
    public GameObject Enemy5;
    public GameObject Enemy5_Trigger;
    public GameObject Enemy6;
    public GameObject Enemy6_Trigger;
    public GameObject Enemy7;
    public GameObject Enemy7_Trigger;
    public GameObject Enemy8;
    public GameObject Enemy8_Trigger;

    public EnemyFollowClass.AI Enemy_1 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_2 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_3 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_4 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_5 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_6 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_7 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_8 = new EnemyFollowClass.AI();

    private void Start()
    {
        Enemy_1.init(Player, Enemy1, 0.035f);
        Enemy_2.init(Player, Enemy2, 0.035f);
        Enemy_3.init(Player, Enemy3, 0.035f);
        Enemy_4.init(Player, Enemy4, 0.035f);
        Enemy_5.init(Player, Enemy5, 0.035f);
        Enemy_6.init(Player, Enemy6, 0.035f);
        Enemy_7.init(Player, Enemy7, 0.035f);
        Enemy_8.init(Player, Enemy8, 0.035f);
    }

    private void Update()
    {
        Enemy_1.move();
        Enemy_2.move();
        Enemy_3.move();
        Enemy_4.move();
        Enemy_5.move();
        Enemy_6.move();
        Enemy_7.move();
        Enemy_8.move();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == Enemy1_Trigger)
        {
            Enemy_1.enable();
            Enemy1_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy2_Trigger)
        {
            Enemy_2.enable();
            Enemy2_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy3_Trigger)
        {
            Enemy_3.enable();
            Enemy3_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy4_Trigger)
        {
            Enemy_4.enable();
            Enemy4_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy5_Trigger)
        {
            Enemy_5.enable();
            Enemy5_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy6_Trigger)
        {
            Enemy_6.enable();
            Enemy6_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy7_Trigger)
        {
            Enemy_7.enable();
            Enemy7_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy8_Trigger)
        {
            Enemy_8.enable();
            Enemy8_Trigger.SetActive(false);
        }
    }
}