using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U1_1_2 : MonoBehaviour
{

    // Multiplicer 'a' og 'b' og divider med c
    // Set svaret ind som argument i Dommer.Udfordring1_1_2('svar her');
    void Start()
    {
        int a = 3434;
        int b = 89;
        int c = 12;
        
        // Svaret skal erstatte '0'
        Dommer.Udfordring1_1_2(a*b/c);
    }
    
}
