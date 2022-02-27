using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I udfordringer 2 skal vi lære om transforms
// Hvis du kigger i Unity under inspector, så kan du se, at hvert objekt har en transform
// En transform indeholder position, rotation, og størrelse (scale)

public class U2_0 : MonoBehaviour
{

    void Start()
    {
        // Positionen fås ved transform.position
        // Positionen er en Vector3, den indeholder altså en x, y, og z værdi
        Vector3 position = transform.position;
        
        // Hvis man vil ændre positionen, skal man ændre den hele Vector3
        
        // Dette ville give en fejl
        // transform.position.x = 10
        
        // Man ændrer positionen ved først at lave en variabel som gjort ovenover ('position')
        // Derefter ændrer man værdien af 'position'
        position.x = 10;
        // Og så sætter man transform.position til 'position' Vector3'en
        transform.position = position;
        
        
        // Rotationer er Quaternioner, og alt for komplekse indtil videre
        Quaternion rotation = transform.rotation;
        
        // Derfor bruger vi eulerAngles i stedet
        // Her kan vi rotere i x, y, og z
        // Men vær opmærksom på, at rotationen ikke altid er den transform.eulerAngles, som du sætter den til fordi, der foregår noget underligt bag scenen med quaternioner
        Vector3 rotationEuler = transform.eulerAngles;
        // Rotationen ændres på samme måde som positionen
        rotationEuler.y = 45;
        transform.eulerAngles = rotationEuler;
        
        
        // Størrelsen kan enten være transform.localScale eller transform.lossyScale
        // Forskellen gennemgås ikke her. Bare brug localScale
        Vector3 størrelse = transform.localScale;
        
        // Man kan også ændre en Vector3 på en enkelt linje
        transform.localScale = new Vector3(1, 1, 2);
        // Her bliver objektet 2 gange større i z-aksen
        // Hvis man sætte størrelsen til 0 i enten x, y eller z-aksen forsvinder objektet
        
        
        // Sæt localScale tilbage til det den var før: (1, 1, 1)
        
        Dommer.Udfordring2_0(transform);
    }

}
