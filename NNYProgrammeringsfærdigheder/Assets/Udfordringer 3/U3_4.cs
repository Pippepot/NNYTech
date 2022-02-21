using UnityEngine;

// Der skal findes nogle vindere i hestevæddeløb ved forskellige distancer

// Skriv din kode i Hest og Hestevæddeløb klasserne

public class Hest
{
    private float hastighed;
    private float udholdenhed;
    
    public Hest(float startHastighed, float startUdholdenhed)
    {
        // Skriv noget mere kode for at tildele hesten en hastighed

    }

    public float LøbeTid(float distance)
    {
        // Udregn hvor lang tid det tager for hesten at løbe distancen ud fra formlen:
        // distance / hastighed + Mathf.Max(distance - udholdenhed, 0) / (udholdenhed * 0.01f)
        // Retuner resultatet

        return 0;
    }
    
}

public class Hestevæddeløb
{
    private Hest[] heste;
    private float distance;

    public Hestevæddeløb(Hest[] hesteIVæddeløb, float løbeDistance)
    {
        // Skriv noget mere kode for at tildele hestene i væddeløbet og tildel distance variablen værdien af 'løbeDistance'

    }

    public Hest FindVinderHestILøb()
    {
        // Find løbetiden for hver hest og retuner den hurtigeste hest.

        return null;
    }

}

public class U3_4 : MonoBehaviour
{
    // Der skal ikke ændres noget kode her
    void Start()
    {
        Hest[] heste = new Hest[32] {new Hest(28, 100) ,new Hest(25.6f, 100) ,new Hest(29.5f, 100) ,new Hest(13.3f, 5273) ,new Hest(11.8f, 226) ,new Hest(10, 3570) ,new Hest(16.5f, 4501) ,new Hest(15.2f, 2781) ,new Hest(27.3f, 100) ,new Hest(13.4f, 1631) ,new Hest(20.6f, 3014) ,new Hest(12.2f, 4295) ,new Hest(27, 717) ,new Hest(19.6f, 3068) ,new Hest(17.7f, 2040) ,new Hest(24.3f, 100) ,new Hest(29, 100) ,new Hest(19.7f, 2777) ,new Hest(26, 100) ,new Hest(15.8f, 3655) ,new Hest(22.7f, 256) ,new Hest(27.4f, 100) ,new Hest(29.1f, 1242) ,new Hest(25.7f, 100) ,new Hest(14.4f, 2559) ,new Hest(24.1f, 3133) ,new Hest(17.7f, 2753) ,new Hest(11.5f, 1512) ,new Hest(26.5f, 100) ,new Hest(11.1f, 100) ,new Hest(13, 1279) ,new Hest(14.8f, 408)};
        Hestevæddeløb væddeløb;
        float[] distancer = new float[5] {100, 200, 500, 1000, 50000};
        Hest[] vinderHeste = new Hest[distancer.Length];
        
        for (int i = 0; i < distancer.Length; i++)
        {
            væddeløb = new Hestevæddeløb(heste, distancer[i]);
            vinderHeste[i] = væddeløb.FindVinderHestILøb();
        }
        
        Dommer.Udfordring3_4(vinderHeste);
    }
    
}

