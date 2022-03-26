using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U1_1_3 : MonoBehaviour
{

    // Multiplicer 'a' med 'b' og træk 'c' fra
    // Divider hele udtrykket med 'd'
    // Set svaret ind som argument i Dommer.Udfordring1_1_3('svar her');
    void Start()
    {
        int a = 46;
        int b = 4;
        int c = 112;
        int d = 2;
        
        // Svaret skal erstatte '0'
        Dommer.Udfordring1_1_3((a * b - c) / d);
    }
    
}
