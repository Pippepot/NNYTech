using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I udfordringer 3 skal vi lære om at lave nye objekter fra kode

public class U3_0 : MonoBehaviour
{

    void Start()
    {
        // For at lave et nyt objekt fra kode, skriver man new GameObject
        GameObject nytObjekt = new GameObject("objekt1");
        // Her laves et nyt GameObject med navnet "objekt1"
        
        // Jeg synes ikke om navnet "objekt1". Jeg giver den et nyt navn
        nytObjekt.name = "super objekt1";
        
        
        // Din opgave er at flytte positionen af det nye objekt til (3, 4, 5)

        
        Dommer.Udfordring3_0();
    }
    
}
