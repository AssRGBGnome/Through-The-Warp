using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathcounterClass : MonoBehaviour
{
    public static class Score
    {
        static public int TotalDeaths = 0;
        static public int[] LevelDeaths = new int[17];

        private static void IncrementTotalDeaths()
        {
            TotalDeaths++;
        }

        private static void IncrementLevelDeaths(int level)
        {
            LevelDeaths[level]++;
        }

        public static void IncrementDeaths( int level)
        {
            IncrementTotalDeaths();
            IncrementLevelDeaths(level);
            Debug.Log(DeathcounterClass.Score.TotalDeaths);
            Debug.Log(DeathcounterClass.Score.LevelDeaths[level]);
        }

    }
}
