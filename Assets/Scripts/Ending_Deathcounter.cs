using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ending_Deathcounter : MonoBehaviour
{
    public TextMeshProUGUI deathcounter_Text;

    private void Update()
    {
        deathcounter_Text.text = "Total Deaths : " + DeathcounterClass.Score.TotalDeaths.ToString();
    }
}