using System;
using UnityEngine;
using UnityEngine.Events;

// Denne knap kan trykkes på, hvis spilleren rører den og trykker 'E'
public class Button : MonoBehaviour
{
    // Dette er en UnityEvent, som vi kan bruge til at kalde en funktion, når knappen trykkes på
    // Inde i Unity editoren, kan det ses, hvilken funktion der skal kaldes, når knappen trykkes på
    public UnityEvent onClick = new UnityEvent();
    public bool isPlayerInRange;
    
    void Update()
    {
        // Find ud af om isPlayerInRange er sandt
        
        // Hvis spilleren trykker 'E', kald eventen 'onClick' med onClick.Invoke();
    }

    // Når spilleren rører knappen, kaldes denne funktion en gang
    void OnTriggerEnter2D(Collider2D other)
    {
        // Spilleren har et 'tag' som er 'Player'
        // Find ud af om 'other' har et 'tag' som er 'Player'
        
        // Hvis 'other' har et 'tag' som er 'Player', sæt 'isPlayerInRange' til 'true'
    }
    
    // Når spilleren ikke længere rører knappen, kaldes denne funktion en gang
    void OnTriggerExit2D(Collider2D other)
    {
        // Find ud af om 'other' har et 'tag' som er 'Player'
        
        // Hvis 'other' har et 'tag' som er 'Player', sæt 'isPlayerInRange' til 'false'
    }
}
