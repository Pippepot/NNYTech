using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U3_1 : MonoBehaviour
{

    public GameObject turretPrefab;
    
    void Start()
    {
        // Vi vil gerne kunne skabe objekter, som vi har lavet på forhånd
        // Disse objekter hedder prefabs
        
        // Træk 'Turret' prefaben ind i inspektoren for udfordringen
        // (hvis du kigger i inspektoren og klikker på udfordringen, vil du se et felt, hvor der står 'None (Game Object)' her skal 'Turret' trækkes fra projektet til dette felt)
        
        // Man kan skabe et prefab objekt ved at skrive:
        GameObject instance = Instantiate(turretPrefab);
        // (Du vil få en error, hvis du ikke har trukket 'Turret' prefaben ind i inspektoren for udfordringen)
        // Her får vi en referance til den skabte prefab, nemlig 'instance'
        // Med denne reference kan vi f.eks. rotere det skabte objekt
        
        // Din opgave er, at rotere 'instance' i y-aksen med 30 grader
        
        // (OBS: 'instance' og 'prefab' er IKKE det samme, hvis du prøver, at rotere 'prefab' sker der ikke noget i spillet)

        Dommer.Udfordring3_1();
    }
    
}
