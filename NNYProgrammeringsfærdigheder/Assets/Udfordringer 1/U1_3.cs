using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U1_3 : MonoBehaviour
{

    // Lav et int array (som du kan kalde 'svar') som er lige så langt som a og b (8 langt)
    // Hvert tal i 'svar' til et givent index skal være lig med a[index] + b[index]
    // Gør brug af for loop til dette
    // Set svaret ind som argument i Dommer.Udfordring('svar her');
    
    // Eventuelle søgeord: 'arrays' 'for loops'
    void Start()
    {
        int[] a = new int[8] {23, 45, 77, 45, 767, 273, 405, 340032};
        int[] b = new int[8] {56, 2, 3, 868, 776, 23, 778, 34};


        // Her skal svaret være et 'int[]' og altså ikke bare et 'int'
        Dommer.Udfordring1_3(null);
    }
    
    #region Hint
    // svar[i] = a[i] + b[i]
    #endregion
}
