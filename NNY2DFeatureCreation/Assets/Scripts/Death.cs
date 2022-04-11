using System;
using UnityEngine;

// Respawn spilleren hvis den rører denne collider
public class Death : MonoBehaviour
{
    // OnTriggerEnter kaldes når spilleren rører denne collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Spilleren har et 'tag' som er 'Player'
        // Find ud af om 'other' har et 'tag' som er 'Player'
        
        // Hvis 'other' har et 'tag' som er 'Player', så set spillerens position til startpositionen
        // Du kan enten sige at startpositionen blot er Vector3.zero, eller at du skal bruge en transform variabel som hedder 'startPosition'
    }
}
