using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy1;
    public GameObject Enemy1_Trigger;
    public GameObject Enemy2;
    public GameObject Enemy2_Trigger;
    public GameObject Enemy3;
    public GameObject Enemy3_Trigger;

    public EnemyFollowClass.AI Enemy_1 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_2 = new EnemyFollowClass.AI();
    public EnemyFollowClass.AI Enemy_3 = new EnemyFollowClass.AI();

    private void Start()
    {
        Enemy_1.init( Player, Enemy1, 0.05f );
        Enemy_2.init(Player, Enemy2, 0.055f);
        Enemy_3.init(Player, Enemy3, 0.056f);
    }

    private void Update()
    {
        Enemy_1.move();
        Enemy_2.move();
        Enemy_3.move();
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
    }
}