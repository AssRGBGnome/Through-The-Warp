using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    public TextMeshProUGUI Special_Text;
    public float EnemyCount = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemies")
        {
            EnemyCount += .5f;
            if (EnemyCount >= 12)
            {
                Special_Text.text = "Hell Yea!";
            }
        }
    }
}