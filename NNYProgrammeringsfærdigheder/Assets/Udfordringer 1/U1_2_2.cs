using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U1_2_2 : MonoBehaviour
{
    // Her gennemgås arrays

    void Start()
    {
        // Der laves et nyt array med 3 elementer
        int[] tal = new int[3];
        
        // Det første element i arrayet bliver sat til 35
        tal[0] = 35;
        
        // Sæt det andet element til 45

        // Sæt det tredje element til det første element plus det andet element

        // Indsæt tal arrayet i Dommer.Udfordringer1_2_2 i stedet for null
        Dommer.Udfordring1_2_2(tal);
    }
    
}
