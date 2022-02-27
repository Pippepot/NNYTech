using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I Udfordringer 4_1 introduceres dictionaries
// Et dictionary har en nøgle 'key' og en værdi 'value'.
// De er tilsammen et 'KeyValuePair'
// Man kan finde en værdi i et dictionary ved at give den rigtige nøgle
// Nok om det! Prøv dig frem eller søg på internettet (eller spørg læreren)

// Eventuelle søgeord: 'c# dictionary'

// Skriv din kode i Start()

public class U4_1 : MonoBehaviour
{
    
    void Start()
    {
        // Her deklareres et dictionary med int keys og string values
        Dictionary<int, string> telefonbog = new Dictionary<int, string>();

        // Her indsættes en telefonnummeret som key og et navn som value
        telefonbog.Add(20459627, "Peter");
        telefonbog.Add(69420666, "Konrad");
        telefonbog.Add(38682747, "Lars");
        
        // Konrad har skiftet navn til "Bartolomæus"
        telefonbog[69420666] = "Bartolomæus";
        
        // Peter har stillet træskoene og han skal fjernes derfor fra telefonbogen
        telefonbog.Remove(20459627);
        
        
        // Lars har fået en søn som hedder "Lars jr."
        // Tilføj Lars jr. med telefonnummeret 39581683
        

        // Bartolomæus har fortrudt og vil skifte sit navn tilbage til "Konrad"
        // Skift hans navn
        

        // Lars er død
        // Fjern lars fra telefonbogen
        
        

        Dommer.Udfordring4_1(telefonbog);
    }
    
    
}

