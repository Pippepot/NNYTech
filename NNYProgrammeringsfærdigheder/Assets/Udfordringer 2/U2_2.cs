using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U2_2 : MonoBehaviour
{

    // Flyt positionen af denne transform til (5, 5, 5)
    // Roter denne transform med 90 i x-aksen
    // Skaler denne transform til (2, 1.2, 0.02)
    
    void Start()
    {
        transform.position = new Vector3(5, 5, 5);
        transform.Rotate(new Vector3(90, 0, 0));
        transform.localScale = new Vector3(2, 1.2f, 0.02f);

        Dommer.Udfordring2_2(transform);

    }
    
    #region Hint 1
    // Ved rotation, gør transform.Rotate
    #endregion
    
}
