using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U1_2_1 : MonoBehaviour
{
    // Her gennemgås arrays

    void Start()
    {
        // Et array er en beholder, som kan holde på mange variable
        // Det kan skrives således
        int[] a = new int[6];
        // 'a' kan altså indeholde 6 tal
        
        // Man kan ændre værdierne af et array ved at skrive navnet på sit array og det index man vil ændre inde i firkantede parenteser
        a[0] = 43;
        // Her ændres det første index i 'a' læg mærke til at indexet starter på 0

        a[5] = 485;
        // Det sidste index er altså 5, da indexet starter på 0
        
        
        // Man kan også lave et array, som indeholder variable fra start
        string[] familieMedlemmer = new string[] {"Bob", "Karen", "Felix", "Lise"};
        // Her behøves man ikke at skrive, hvor langt arrayet er. Det bliver 4 langt, da der er 4 navne
        
        // Prøv at ændre "Bob" i familieMedlemmer til "Bobby" på samme måde som vi ændrede værdien for 'a' ovenover
        
        // Erstat 'null' med 'familiemedlemmer' i Dommer.Udfordring1_2_1 
        // Her er det vigtigt, at man ikke indsætter "Bobby", da man får en fejl.
        // Dommer.Udfordring1_2_3 spørger om et string[], det vil sige, at den vil have beholderen, som indeholder alle navnene, altså 'familiemedlemmer'
        Dommer.Udfordring1_2_1(null);
    }
    
}
