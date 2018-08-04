using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy1;
    public GameObject Enemy1_Trigger;

    public EnemyFollowClass.AI Enemy_1 = new EnemyFollowClass.AI();

    private void Start()
    {
        Enemy_1.init( Player, Enemy1, 0.045f );
    }

    private void Update()
    {
        Enemy_1.move();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == Enemy1_Trigger)
        {
            Enemy_1.enable();
            Enemy1_Trigger.SetActive(false);
        }
    }
}