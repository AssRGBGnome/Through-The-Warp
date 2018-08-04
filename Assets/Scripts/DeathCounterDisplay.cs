using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCounterDisplay : MonoBehaviour
{
    public TextMeshProUGUI deathcounter_Text;

    private void Update()
    {
        deathcounter_Text.text = DeathcounterClass.Score.TotalDeaths.ToString();
    }
}