using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy1;
    public GameObject Enemy1_Trigger;

    public EnemyFollowClass.AI a = new EnemyFollowClass.AI();

    private void Start()
    {
        a.init( Player, Enemy1, 0.07f );
    }

    private void Update()
    {
        a.move();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == Enemy1_Trigger)
        {
            a.enable();
        }
    }
}