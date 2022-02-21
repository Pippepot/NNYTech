using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U2_2 : MonoBehaviour
{

    // Flyt positionen af denne transform til (5, 5, 5)
    // Roter denne transform til (180, 45, 23)
    // Skaler denne transform til (2, 1.2, 0.02)
    
    void Start()
    {

        Dommer.Udfordring2_2(transform);
    }
    
    #region Hint 1
    // Ved rotation, gør brug af transform.eulerAngles
    #endregion
    
}
