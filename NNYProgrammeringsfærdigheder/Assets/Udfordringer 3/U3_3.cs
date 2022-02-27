using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Vi laver nu et turret som kan skyde projektiler

public class U3_3 : MonoBehaviour
{

    public Transform aimPoint;
    public GameObject projectilePrefab;
    
    void Start()
    {
        // Under dette objekt er der et 'Turret' og et 'AimPoint'
        // Træk 'AimPoint' ind i 'aimPoint' feltet i inspektoren
        
        // Træk 'Projectile' prefaben ind i 'projectilePrefab' feltet i inspektoren

        // Roter denne transform med 45 grader i y-aksen

        // Instantiate 'projectilePrefab'
        // Lav en 'instance' variabel og sæt den lig Instantiate... (ligesom før)

        // Set position af 'instance' til 'aimPoint'

        // Få en referance til projektilens Rigidbody med GetComponent (ligesom før)

        // Giv projektilen en kraft med den retning, som aimPoint peger og gang dette med 10.
        

        Dommer.Udfordring3_3(this);
    }
    
}
