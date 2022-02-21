using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U2_1 : MonoBehaviour
{

    // Flyt positionen af denne transform til (10, 10, 10)
    
    void Start()
    {
        
        
        Dommer.Udfordring2_1(transform);
    }
    
    #region Hint 1
    // Gør brug af transform.position
    #endregion
    
}
