using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Skriv din kode i Start()

public class U1_4 : MonoBehaviour
{

    // Lav et int array (som du kan kalde 'svar') som er lige så langt som a
    // Hvis et tal til et indeks i a er større end 100, er 'svar' til indekset lig med det tal. Ellers er 'svar' til indekset 0
    
    // F.eks. hvis a[index] = 45, er svar[index] = 0
    // Eller hvis a[index] = 120, er svar[index] = 120
    
    // Gør brug af for loop til dette
    // Det lyder lidt kryptisk. Gør eventuelt brug af hintet forneden.
    // Set svaret ind som argument i Dommer.Udfordring('svar her');
    
    // Eventuelle søgeord: 'arrays' 'for loops'
    void Start()
    {
        int[] a = new int[256] {45, 21 ,123 ,167 ,69 ,75 ,33 ,137 ,82 ,170 ,102 ,110 ,19 ,9 ,133 ,183 ,3 ,47 ,11 ,24 ,29 ,11 ,103 ,81 ,18 ,73 ,43 ,109 ,55 ,174 ,50 ,89 ,112 ,173 ,47 ,146 ,87 ,133 ,14 ,175 ,68 ,186 ,42 ,1 ,50 ,8 ,133 ,118 ,75 ,185 ,160 ,112 ,7 ,90 ,51 ,83 ,115 ,61 ,99 ,92 ,175 ,175 ,188 ,67 ,24 ,113 ,45 ,169 ,180 ,124 ,193 ,53 ,173 ,102 ,62 ,148 ,48 ,146 ,191 ,94 ,125 ,59 ,118 ,102 ,67 ,70 ,111 ,39 ,11 ,89 ,77 ,192 ,43 ,115 ,99 ,97 ,64 ,172 ,145 ,77 ,125 ,64 ,38 ,131 ,35 ,138 ,74 ,166 ,94 ,119 ,178 ,154 ,65 ,30 ,35 ,44 ,70 ,146 ,176 ,123 ,64 ,160 ,171 ,12 ,30 ,145 ,31 ,87 ,102 ,140 ,187 ,143 ,177 ,95 ,155 ,78 ,46 ,151 ,195 ,34 ,82 ,144 ,85 ,39 ,158 ,102 ,158 ,94 ,192 ,34 ,126 ,150 ,67 ,104 ,190 ,67 ,14 ,112 ,155 ,40 ,181 ,170 ,31 ,135 ,91 ,8 ,45 ,66 ,35 ,88 ,128 ,84 ,145 ,174 ,104 ,126 ,89 ,102 ,17 ,70 ,74 ,71 ,86 ,182 ,148 ,68 ,128 ,155 ,46 ,54 ,23 ,21 ,155 ,172 ,93 ,165 ,147 ,34 ,157 ,64 ,97 ,90 ,97 ,69 ,187 ,76 ,74 ,4 ,180 ,4 ,51 ,25 ,103 ,7 ,40 ,91 ,14 ,97 ,124 ,74 ,21 ,63 ,74 ,45 ,157 ,99 ,167 ,197 ,46 ,106 ,150 ,16 ,48 ,199 ,110 ,76 ,42 ,166 ,17 ,28 ,176 ,77 ,61 ,128 ,67 ,182 ,148 ,100 ,21 ,178 ,190 ,80 ,1 ,119 ,187 ,28};
        
        Dommer.Udfordring1_4(null);
    }
    
    #region Hint
    // hvis a[i] større end 100
    //      svar[i] = a[i]
    // ellers
    //      svar[i] = 0;
    #endregion
}
