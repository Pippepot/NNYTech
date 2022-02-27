using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i AdvanceretKriger classen

public class AdvanceretKriger
{
    // Hvis en variabel har { get; private set; } hedder det en property
    // Disse properties gør at andre classes ikke kan ændre vores variable, men kan kun se hvad deres værdier er
    // Dette er smart fordi man undgår at ens variable bliver ændret alle mulige steder
    public int liv { get; private set; }
    public int skade { get; private set; }
    public int blokering { get; private set; } // Hver gang man tager skade, trækkes blokering fra
    
    public AdvanceretKriger(int startLiv, int startSkade, int startBlokering)
    {
        // Skriv noget mere kode for at give krigeren liv, skade og blokering

    }

    public void Angrib(AdvanceretKriger andenKriger)
    {
        // Skriv noget mere kode for at skade den anden kriger
    }
    
    public void TagSkade(int skade)
    {
        // Skriv noget mere kode for at skade krigeren
        // blokering trækkes fra skaden
        // skaden kan ikke være mindre end 1

    }
}

public class U3_3 : MonoBehaviour
{
    
    void Start()
    {
        // Der skal ikke ændres noget kode her
        List<AdvanceretKriger> krigere = new List<AdvanceretKriger>(){new AdvanceretKriger(6, 2, 3) ,new AdvanceretKriger(9, 2, 2) ,new AdvanceretKriger(2, 5, 0) ,new AdvanceretKriger(9, 5, 1) ,new AdvanceretKriger(7, 5, 3) ,new AdvanceretKriger(5, 1, 2) ,new AdvanceretKriger(6, 4, 1) ,new AdvanceretKriger(6, 3, 1) ,new AdvanceretKriger(1, 1, 1) ,new AdvanceretKriger(9, 5, 0) ,new AdvanceretKriger(3, 5, 3) ,new AdvanceretKriger(6, 4, 1) ,new AdvanceretKriger(5, 2, 1) ,new AdvanceretKriger(8, 1, 1) ,new AdvanceretKriger(6, 3, 3) ,new AdvanceretKriger(2, 1, 3) ,new AdvanceretKriger(4, 1, 1) ,new AdvanceretKriger(1, 1, 0) ,new AdvanceretKriger(5, 5, 0) ,new AdvanceretKriger(3, 1, 3) ,new AdvanceretKriger(9, 2, 3) ,new AdvanceretKriger(7, 1, 0) ,new AdvanceretKriger(6, 2, 2) ,new AdvanceretKriger(1, 2, 1) ,new AdvanceretKriger(6, 5, 0) ,new AdvanceretKriger(9, 1, 0) ,new AdvanceretKriger(4, 1, 1) ,new AdvanceretKriger(5, 5, 1) ,new AdvanceretKriger(3, 4, 3) ,new AdvanceretKriger(3, 5, 3) ,new AdvanceretKriger(6, 4, 2) ,new AdvanceretKriger(2, 1, 3) ,new AdvanceretKriger(7, 3, 0) ,new AdvanceretKriger(4, 4, 1) ,new AdvanceretKriger(4, 1, 0) ,new AdvanceretKriger(4, 4, 0) ,new AdvanceretKriger(4, 1, 1) ,new AdvanceretKriger(2, 3, 1) ,new AdvanceretKriger(9, 3, 0) ,new AdvanceretKriger(2, 1, 1) ,new AdvanceretKriger(3, 5, 1) ,new AdvanceretKriger(9, 1, 0) ,new AdvanceretKriger(5, 1, 1) ,new AdvanceretKriger(3, 5, 2) ,new AdvanceretKriger(4, 3, 2) ,new AdvanceretKriger(9, 4, 2) ,new AdvanceretKriger(7, 4, 3) ,new AdvanceretKriger(3, 3, 2) ,new AdvanceretKriger(5, 4, 0) ,new AdvanceretKriger(9, 3, 3) ,new AdvanceretKriger(2, 2, 3) ,new AdvanceretKriger(1, 3, 3) ,new AdvanceretKriger(8, 4, 3) ,new AdvanceretKriger(9, 5, 3) ,new AdvanceretKriger(7, 2, 0) ,new AdvanceretKriger(9, 2, 2) ,new AdvanceretKriger(8, 4, 0) ,new AdvanceretKriger(1, 5, 3) ,new AdvanceretKriger(8, 5, 3) ,new AdvanceretKriger(4, 2, 1) ,new AdvanceretKriger(3, 5, 2) ,new AdvanceretKriger(3, 3, 1) ,new AdvanceretKriger(1, 4, 3) ,new AdvanceretKriger(1, 1, 0) ,new AdvanceretKriger(8, 5, 2) ,new AdvanceretKriger(3, 3, 1) ,new AdvanceretKriger(1, 1, 2) ,new AdvanceretKriger(5, 5, 0) ,new AdvanceretKriger(9, 5, 1) ,new AdvanceretKriger(6, 4, 1) ,new AdvanceretKriger(7, 5, 2) ,new AdvanceretKriger(2, 3, 0) ,new AdvanceretKriger(3, 4, 3) ,new AdvanceretKriger(7, 5, 3) ,new AdvanceretKriger(1, 5, 1) ,new AdvanceretKriger(6, 2, 3) ,new AdvanceretKriger(2, 1, 1) ,new AdvanceretKriger(3, 5, 0) ,new AdvanceretKriger(9, 1, 1) ,new AdvanceretKriger(7, 5, 1) ,new AdvanceretKriger(1, 5, 0) ,new AdvanceretKriger(3, 5, 2) ,new AdvanceretKriger(4, 4, 2) ,new AdvanceretKriger(5, 5, 3) ,new AdvanceretKriger(7, 3, 2) ,new AdvanceretKriger(2, 4, 1) ,new AdvanceretKriger(3, 3, 0) ,new AdvanceretKriger(1, 3, 2) ,new AdvanceretKriger(2, 4, 3) ,new AdvanceretKriger(4, 4, 1) ,new AdvanceretKriger(7, 2, 1) ,new AdvanceretKriger(3, 2, 3) ,new AdvanceretKriger(8, 2, 2) ,new AdvanceretKriger(5, 5, 1) ,new AdvanceretKriger(4, 4, 0) ,new AdvanceretKriger(3, 4, 1) ,new AdvanceretKriger(5, 1, 3) ,new AdvanceretKriger(9, 2, 2) ,new AdvanceretKriger(7, 2, 1) ,new AdvanceretKriger(2, 3, 0) ,new AdvanceretKriger(7, 4, 2) ,new AdvanceretKriger(3, 4, 3) ,new AdvanceretKriger(4, 2, 3) ,new AdvanceretKriger(3, 2, 1) ,new AdvanceretKriger(8, 5, 2) ,new AdvanceretKriger(5, 2, 1) ,new AdvanceretKriger(8, 3, 3) ,new AdvanceretKriger(8, 4, 0) ,new AdvanceretKriger(3, 5, 2) ,new AdvanceretKriger(5, 2, 3) ,new AdvanceretKriger(3, 3, 2) ,new AdvanceretKriger(3, 5, 1) ,new AdvanceretKriger(4, 4, 0) ,new AdvanceretKriger(6, 3, 0) ,new AdvanceretKriger(8, 4, 3) ,new AdvanceretKriger(4, 1, 3) ,new AdvanceretKriger(8, 4, 0) ,new AdvanceretKriger(6, 2, 0) ,new AdvanceretKriger(4, 2, 2) ,new AdvanceretKriger(3, 2, 1) ,new AdvanceretKriger(6, 4, 3) ,new AdvanceretKriger(4, 3, 3) ,new AdvanceretKriger(1, 2, 2) ,new AdvanceretKriger(9, 1, 3) ,new AdvanceretKriger(9, 3, 0) ,new AdvanceretKriger(9, 3, 1) ,new AdvanceretKriger(7, 3, 2) ,new AdvanceretKriger(7, 2, 1)};

        while (krigere.Count > 1)
        {
            krigere[0].Angrib(krigere[1]);
            if (krigere[1].liv <= 0)
            {
                krigere.RemoveAt(1);
            }
            else
            {
                krigere[1].Angrib(krigere[0]);
                if (krigere[0].liv <= 0)
                {
                    krigere.RemoveAt(0);
                }
            }

        }

        Dommer.Udfordring3_3(krigere[0]);
    }

    #region Hint 1

    // Skaden udregnes: liv = skade - blokering
    // man kan bruge Mathf.Max for at skaden ikke bliver mindre end 1

    #endregion
}

