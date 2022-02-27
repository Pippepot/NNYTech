using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I Udfordringer 3 introduceres classes
// I gør allerede brug af en class i hvert script f.eks. 'public class U3_1 : MonoBehaviour'
// Denne gang har vi med to classes at gøre.
// Prøv dig frem og se hvad man kan gøre med sådan en class

// Eventuelle søgeord: 'c# class'

// Skriv din kode i Person classen

public class Person
{
    // En person har en alder
    // Alderen ændres når personen har fødselsdag
    
    
    public int alder;

    public Person(int startAlder)
    {
        // Skriv noget mere kode for at give personen en alder
        
    }
    
    public void Fødselsdag()
    {
        // Skriv noget mere kode. Personen skal blive 1 år ældre når han/hun har fødselsdag
        
    }
}


public class U3_1 : MonoBehaviour
{
    
    void Start()
    {
        // Der skal ikke ændres noget kode her
        Person peter = new Person(15);
        for (int i = 0; i < 3; i++)
        {
            peter.Fødselsdag();
        }
        
        Dommer.Udfordring3_1(peter);
    }
    
    
}

