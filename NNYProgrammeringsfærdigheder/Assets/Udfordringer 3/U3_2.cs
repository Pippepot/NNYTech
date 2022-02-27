using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U3_2 : MonoBehaviour
{

    public GameObject projectilePrefab;
    
    void Start()
    {
        // Træk 'Projectile' prefaben ind i 'projectilePrefab' feltet i inspektoren, ligesom du gjorde før med 'Turret'
        
        GameObject instance = null;
        // Instantiate 'projectilePrefab' ligesom du gjorde før med 'Turret' og set 'instance' lig med det, som du instanciater (ligesom før)

        // 'projectilePrefab' har et Rigidbody component, som sørger for fysikken
        // Vi kan få en reference til et component ved GetComponent<'component'>()
        Rigidbody body = instance.GetComponent<Rigidbody>();
        // OBS: dette vil give en fejl, hvis du ikke har sat 'instance' til det du instantiater
        
        // Giv projektilen en opadgående kraft med body.AddForce
        // Det er lige meget hvor stor kraften er, bare den går opad
        // Brug ForceMode.Impulse

        Dommer.Udfordring3_2(this);
    }
    
}
