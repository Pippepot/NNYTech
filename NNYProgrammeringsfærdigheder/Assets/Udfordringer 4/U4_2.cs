using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Vi skal programmere et system, der kan holde styr på nogle spillere i et spil og hvor mange point de har

// Eventuelle søgeord: 'c# dictionary'

// Skriv din kode i Start()

public class U4_2 : MonoBehaviour
{
    
    void Start()
    {
        // Tag dig ikke af dette :)
        Random.InitState(0);
        
        // Her er key og value byttet om fra sidste opgave
        // Key er navnet på en spiller og value er spillerens point
        Dictionary<string, int> spillerPoint = new Dictionary<string, int>();

        // 2 spillere er med til at spille. De starter med 0 point
        spillerPoint.Add("Player 1", 0);
        spillerPoint.Add("Player 2", 0);

        int spilleRunder = 20;
        for (int i = 0; i < spilleRunder; i++)
        {
            // Hver runde kan hver spiller få 0 til 5 point (6 er ekslusiv)
            spillerPoint["Player 1"] += Random.Range(0, 6);
            spillerPoint["Player 2"] += Random.Range(0, 6);

            // Hvis en spiller har præcis 10 point får spilleren 5 mere
            // Skriv noget kode så dette sker
            
            

            // Spilleren med højest antal point mister 1 point
            // Hvis spillerene har lige antal point sker der ikke noget
            // Skriv noget kode så dette sker
            

        }
        
        
        Dommer.Udfordring4_2(spillerPoint);
    }
    
    
}

