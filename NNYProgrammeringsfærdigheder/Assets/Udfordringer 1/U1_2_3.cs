using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U1_2_3 : MonoBehaviour
{
    // Her gennemgås for loops

    void Start()
    {
        // Et for loop kan køre den samme kode flere gange
        // Det kan skrives således
        for (int i = 0; i < 5; i++)
        {
            
        }
        // Et for loop er delt op således:
        // for (erklæring 1; erklæring 2; erklæring 3)
        
        // I den første erklæring laves en ny variabel 'int i', som sættes til 0 : erklæring 1 køres kun 1 gang
        // I den anden erklæring, står der, hvornår loopet skal stoppe           : erklæring 2 tjekkes, hver gang loopet har kørt en omgang
        // Altså, når 'i' ikke er mindre en 5
        // Den sidste erklæring siger, at 'i' bliver 1 større (i++)              : erklæring 3 køres, hver gang loopet har kørt en omgang

        
        // Det kan godt virke lidt kompliceret, men det man skal tænke på er, at et for loop kører éns kode, så mange gange, som der står på 5-tallets plads (i erklæring 2)
        
        
        // I et for loop kan man snildt operere på alle elementer i et array:
        int[] talArray = new int[] {45, 23, 46, 39, 79, 23};
        int højesteTal = 0;
        for (int i = 0; i < talArray.Length; i++)
        {
            if (talArray[i] > højesteTal)
            {
                højesteTal = talArray[i];
            }   
        }
        // Her findes det højeste tal blandt talene i 'talArray'
        // for loopet kører koden, så mange gange, som der er tal i 'talArray'
        // 'i' bliver 1 større for hver gang, loopet kører
        // 'i' starter altså på 0, så 1 så 2 osv. indtil 'i' er lig med det sidste index i talArray (her bliver 'i' lig 5)

        // Prøv at finde det laveste tal med forrige metode i 'talArray2'
        int[] talArray2 = new int[] {340, 235, 893, 777, 482, 512, 703, 917, 419, 811, 835, 584, 349, 965, 306, 403, 297, 889, 580, 416, 628, 907, 981, 439, 203, 847, 102, 433, 894, 768, 277, 780, 339, 694, 160, 476, 511, 816, 638, 463, 726, 846, 371, 50, 211, 428, 810, 435, 942, 816, 339, 496, 280, 890, 35, 946, 576, 618, 919, 171, 35, 699, 930, 118, 818, 276, 560, 834, 303, 957, 872, 380, 907, 228, 202, 694, 436, 70, 457, 624, 911, 493, 865, 882, 281, 641, 96, 612, 266, 998, 474, 746, 726, 785, 105, 41, 554, 790, 131, 827, 322, 999, 477, 160, 229, 541, 382, 642, 961, 327, 126, 419, 239, 579, 110, 823, 210, 965, 760, 592, 623, 410, 675, 686, 977, 492, 971, 317, 627, 172, 401, 561, 219, 491, 606, 959, 239, 666, 239, 61, 114, 975, 298, 805, 664, 52, 334, 870, 346, 872, 957, 140, 824, 828, 618, 822, 845, 63, 966, 691, 63, 370, 439, 754, 490, 470, 986, 569, 740, 880, 235, 960, 779, 906, 78, 671, 518, 512, 600, 706, 833, 772, 349, 446, 343, 210, 215, 686, 501, 141, 412, 440, 617, 716, 207, 501, 112, 500, 659, 144, 850, 695, 898, 604, 992, 349, 908, 797, 624, 160, 202, 946, 337, 669, 649, 543, 784, 332, 714, 680, 674, 407, 888, 875, 573, 167, 158, 163, 968, 165, 553, 546, 191, 844, 409, 996, 854, 241, 688, 826, 761, 696, 986, 194, 63, 893, 193, 734, 757, 370, 200, 588, 97, 581, 827, 745};
        


        // Indsæt det laveste tal i Dommer.Udfordring1_2_2
        Dommer.Udfordring1_2_3(0);
    }
    
}
