using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U1_2_3 : MonoBehaviour
{

    // Lav en variabel som lægger alle tallene i 'a' sammen (summen af tallene i 'a')
    // Gør brug af for loop til dette
    // Set svaret ind som argument i Dommer.Udfordring;
    
    void Start()
    {
        int[] a = new int[] {23, 45, 76, 45, 767, 273, 405, 340032};
        for (int i = 0; i < a.Length; i++)
        {
            
        }

        Dommer.Udfordring1_2_3(0);
    }
    
}
