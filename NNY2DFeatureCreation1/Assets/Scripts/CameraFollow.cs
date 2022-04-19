using System;
using UnityEngine;

// Gør at kameraet følger spilleren
public class CameraFollow : MonoBehaviour
{
    // Lave en transform variabel til at holde styr på spilleren

    // Inde i update skal kameraets position sættes til at være lig spillerens position
    // Vær opmærksom på, at kameraets z-værdi er -10 og hvis vi sætter den til spillerens z-værdi, som er 0, så vil kameraet ikke kunne se spilleren og omgivelserne
    void Update()
    {
        // Find kameraets position
        
        // Find spillerens position
        
        // Sæt kameraets position til at være lig spillerens position, undtagende z-værdien
    }
}
