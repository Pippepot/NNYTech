using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I udfordringer 4 skal vi lære om input

public class U4_0 : MonoBehaviour
{

    // Der defineres et GameObject variabel som vi kalder player
    private GameObject player;

    void Start()
    {
        // Vi sætter player gameobjectet til at være et nyt gameobject med navnet "player"
        player = new GameObject("player");
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Dommer.Udfordring4_0(transform);

        }

    }

}
