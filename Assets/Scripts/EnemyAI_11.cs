using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_11 : MonoBehaviour
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
    public GameObject Enemy9;
    public GameObject Enemy9_Trigger;
    public GameObject Enemy10;
    public GameObject Enemy10_Trigger;
    public GameObject Enemy11;
    public GameObject Enemy11_Trigger;
    public GameObject Enemy12;
    public GameObject Enemy12_Trigger;
    public GameObject Enemy13;
    public GameObject Enemy13_Trigger;
    public GameObject Enemy14;
    public GameObject Enemy14_Trigger;
    public GameObject Enemy15;
    public GameObject Enemy15_Trigger;
    public GameObject Enemy16;
    public GameObject Enemy16_Trigger;

    public EnemyFollowClass.AI Enemy_1 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_2 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_3 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_4 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_5 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_6 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_7 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_8 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_9 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_10 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_11 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_12 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_13 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_14 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_15 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_16 = new EnemyFollowClass.AI();

    private void Start()
    {
        Enemy_1.init(Player, Enemy1, 0.035f);
        Enemy_2.init(Player, Enemy2, 0.036f);
        Enemy_3.init(Player, Enemy3, 0.035f);
        Enemy_4.init(Player, Enemy4, 0.036f);
        Enemy_5.init(Player, Enemy5, 0.035f);
        Enemy_6.init(Player, Enemy6, 0.036f);
        Enemy_7.init(Player, Enemy7, 0.035f);
        Enemy_8.init(Player, Enemy8, 0.03f);
        Enemy_9.init(Player, Enemy9, 0.03f);
        Enemy_10.init(Player, Enemy10, 0.03f);
        Enemy_11.init(Player, Enemy11, 0.035f);
        Enemy_12.init(Player, Enemy12, 0.036f);
        Enemy_13.init(Player, Enemy13, 0.035f);
        Enemy_14.init(Player, Enemy14, 0.036f);
        Enemy_15.init(Player, Enemy15, 0.035f);
        Enemy_16.init(Player, Enemy16, 0.036f);
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
        Enemy_9.move();
        Enemy_10.move();
        Enemy_11.move();
        Enemy_12.move();
        Enemy_13.move();
        Enemy_14.move();
        Enemy_15.move();
        Enemy_16.move();
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
        if (other.gameObject == Enemy9_Trigger)
        {
            Enemy_9.enable();
            Enemy9_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy10_Trigger)
        {
            Enemy_10.enable();
            Enemy10_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy11_Trigger)
        {
            Enemy_11.enable();
            Enemy11_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy12_Trigger)
        {
            Enemy_12.enable();
            Enemy12_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy13_Trigger)
        {
            Enemy_13.enable();
            Enemy13_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy14_Trigger)
        {
            Enemy_14.enable();
            Enemy14_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy15_Trigger)
        {
            Enemy_15.enable();
            Enemy15_Trigger.SetActive(false);
        }
        if (other.gameObject == Enemy16_Trigger)
        {
            Enemy_16.enable();
            Enemy16_Trigger.SetActive(false);
        }
    }
}