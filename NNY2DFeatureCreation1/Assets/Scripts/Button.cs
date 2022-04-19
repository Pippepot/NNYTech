using System;
using UnityEngine;
using UnityEngine.Events;

// Denne knap kan trykkes på, hvis spilleren rører den og trykker 'E'
public class Button : MonoBehaviour
{
    // Dette er en UnityEvent, som vi kan bruge til at kalde en funktion, når knappen trykkes på
    // Inde i Unity editoren, kan det ses, hvilken funktion der skal kaldes, når knappen trykkes på
    public UnityEvent onClick = new UnityEvent();

    // Når spilleren rører knappen, kaldes denne funktion hver frame (ligesom Update)
    void OnTriggerStay2D(Collider2D other)
    {
        // Spilleren har et 'tag' som er 'Player'
        // Find ud af om 'other' har et 'tag' som er 'Player'
        
        // Find ud af om spilleren har trykket 'E'
        
        // Hvis spilleren har trykket 'E', kald funktionen 'onClick'
    }
}
