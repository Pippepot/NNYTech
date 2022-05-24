using UnityEngine;

// Dette er en fjende som følger efter spilleren, når den kan se spilleren
public class Enemy : MonoBehaviour
{
    // Lav en float variable som holder styr på hvor hurtigt fjenden skal bevæge sig
    
    // Lav en float variable som holder styr på, hvor langt fjenden kan se

    Transform player;
    Rigidbody2D body;
    bool canSeePlayer;
    void Start()
    {
        // Hvis vi skifter scene, kan fjenerne ikke finde spilleren, hvis vi blot laver direkte referencer
        // Derfor finder vi spilleren dynamisk, ved at søge efter spillerens tag
        player = GameObject.FindGameObjectWithTag("Player").transform;

        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckIfCanSeePlayer();
        MoveTowardPlayer();
    }
    
    void CheckIfCanSeePlayer()
    {
        // Find ud af, om fjenden kan se spilleren
        // Til dette bruger vi en Raycast2D
        
        // Hvis vores raycast rammer et objekt med tag 'Player', så kan vi se spilleren
    }
    
    void MoveTowardPlayer()
    {
        // Hvis vi ikke kan se spilleren, så skal vi ikke gøre noget her
        
        // Hvis vi kan se spilleren, så skal fjenden bevæge sig mod spilleren
        // Brug body.velocity til at bevæge fjenden (husk at gange med fjendens hastighed)
    }
}
