using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U2_4 : MonoBehaviour
{

    // Roter denne transform med (45, 80, 270)
    // Flyt derefter objektet 10 frem i den retning som objektet peger
    // Objektet peger mod transform.forward

    void Start()
    {

        Dommer.Udfordring2_4(transform);
    }

}
