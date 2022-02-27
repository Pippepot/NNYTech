using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Kriger classen

public class Kriger
{
    public int level;

    public Kriger(int startLevel)
    {
        // Skriv noget mere kode for at give krigeren et level

    }
    
    public bool Battle(Kriger modstander)
    {
        // Skriv noget mere kode:
        // Når krigeren kæmper mod en anden kriger, vinder den kriger med højeste level
        // Krigeren som vinder stiger også et level op (level + 1)
        // Return true hvis denne kriger vinder og return false hvis den taber

        return true;
    }
}

public class U3_2 : MonoBehaviour
{
    
    void Start()
    {
        // Der skal ikke ændres noget kode her
        List<Kriger> krigere = new List<Kriger>()
        {
            new Kriger(2), new Kriger(1), new Kriger(2), new Kriger(5), new Kriger(34), new Kriger(34), new Kriger(35),
            new Kriger(35), new Kriger(13), new Kriger(34), new Kriger(2), new Kriger(1), new Kriger(2), new Kriger(5), new Kriger(34), new Kriger(34), new Kriger(35),
        };
        while (krigere.Count > 1)
        {
            if (krigere[0].Battle(krigere[1]))
            {
                krigere.RemoveAt(1);
            }
            else
            {
                krigere.RemoveAt(0);
            }

        }
        
        Dommer.Udfordring3_2(krigere[0]);
    }
    
    
}

