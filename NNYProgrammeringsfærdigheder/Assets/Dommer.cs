using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using UnityEngine;

// Det er egentligt ikke meningen at denne class skal læse
// Den indeholder alle svarene uden at indeholde metoden for at nå frem til svarene
public static class Dommer
{
    #region 1
    
    public static void Udfordring1_1(int answer)
    {
        if (answer == 353206)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_1), true);
            return;
        }

        WriteProgress(typeof(U1_1), false);
        throw new WrongAnswerExeption($"{answer} er ikke det korrekte svar");
    }
    
    public static void Udfordring1_2(int answer)
    {
        if (answer == 341666)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_2), true);
            return;
        }

        WriteProgress(typeof(U1_2), false);
        throw new WrongAnswerExeption($"{answer} er ikke det korrekte svar");
    }
    
    public static void Udfordring1_3(int[] answer)
    {
        if (answer.SequenceEqual(new int[] {79, 47, 80, 913, 1543, 296, 1183, 340066}))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_3), true);
            return;
        }

        WriteProgress(typeof(U1_3), false);
        throw new WrongAnswerExeption($"Ikke korrekt svar");
    }
    
    public static void Udfordring1_4(int[] answer)
    {
        if (answer.SequenceEqual(new int[] {0 ,0 ,123 ,167 ,0 ,0 ,0 ,137 ,0 ,170 ,102 ,110 ,0 ,0 ,133 ,183 ,0 ,0 ,0 ,0 ,0 ,0 ,103 ,0 ,0 ,0 ,0 ,109 ,0 ,174 ,0 ,0 ,112 ,173 ,0 ,146 ,0 ,133 ,0 ,175 ,0 ,186 ,0 ,0 ,0 ,0 ,133 ,118 ,0 ,185 ,160 ,112 ,0 ,0 ,0 ,0 ,115 ,0 ,0 ,0 ,175 ,175 ,188 ,0 ,0 ,113 ,0 ,169 ,180 ,124 ,193 ,0 ,173 ,102 ,0 ,148 ,0 ,146 ,191 ,0 ,125 ,0 ,118 ,102 ,0 ,0 ,111 ,0 ,0 ,0 ,0 ,192 ,0 ,115 ,0 ,0 ,0 ,172 ,145 ,0 ,125 ,0 ,0 ,131 ,0 ,138 ,0 ,166 ,0 ,119 ,178 ,154 ,0 ,0 ,0 ,0 ,0 ,146 ,176 ,123 ,0 ,160 ,171 ,0 ,0 ,145 ,0 ,0 ,102 ,140 ,187 ,143 ,177 ,0 ,155 ,0 ,0 ,151 ,195 ,0 ,0 ,144 ,0 ,0 ,158 ,102 ,158 ,0 ,192 ,0 ,126 ,150 ,0 ,104 ,190 ,0 ,0 ,112 ,155 ,0 ,181 ,170 ,0 ,135 ,0 ,0 ,0 ,0 ,0 ,0 ,128 ,0 ,145 ,174 ,104 ,126 ,0 ,102 ,0 ,0 ,0 ,0 ,0 ,182 ,148 ,0 ,128 ,155 ,0 ,0 ,0 ,0 ,155 ,172 ,0 ,165 ,147 ,0 ,157 ,0 ,0 ,0 ,0 ,0 ,187 ,0 ,0 ,0 ,180 ,0 ,0 ,0 ,103 ,0 ,0 ,0 ,0 ,0 ,124 ,0 ,0 ,0 ,0 ,0 ,157 ,0 ,167 ,197 ,0 ,106 ,150 ,0 ,0 ,199 ,110 ,0 ,0 ,166 ,0 ,0 ,176 ,0 ,0 ,128 ,0 ,182 ,148 ,0 ,0 ,178 ,190 ,0 ,0 ,119 ,187 ,0}))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_4), true);
            return;
        }

        WriteProgress(typeof(U1_4), false);
        throw new WrongAnswerExeption($"Ikke korrekt svar");
    }
    
    public static void Udfordring1_5(int[] answer)
    {
        if (answer.SequenceEqual(new int[] {45 ,21 ,123 ,167 ,63 ,75 ,33 ,137 ,0 ,0 ,0 ,0 ,19 ,9 ,133 ,183 ,3 ,47 ,11 ,0 ,29 ,11 ,103 ,81 ,0 ,73 ,43 ,109 ,55 ,0 ,0 ,89 ,0 ,173 ,47 ,0 ,87 ,133 ,0 ,175 ,0 ,0 ,0 ,1 ,0 ,0 ,133 ,0 ,75 ,185 ,0 ,0 ,7 ,0 ,51 ,83 ,115 ,61 ,99 ,0 ,175 ,175 ,0 ,67 ,0 ,113 ,45 ,169 ,0 ,0 ,193 ,53 ,173 ,0 ,0 ,0 ,0 ,0 ,191 ,0 ,125 ,59 ,0 ,0 ,67 ,0 ,111 ,39 ,11 ,89 ,77 ,0 ,43 ,115 ,99 ,97 ,0 ,0 ,145 ,77 ,125 ,0 ,0 ,131 ,35 ,0 ,0 ,0 ,0 ,119 ,0 ,0 ,65 ,0 ,35 ,0 ,0 ,0 ,0 ,123 ,0 ,0 ,171 ,0 ,0 ,145 ,31 ,87 ,0 ,0 ,187 ,143 ,177 ,95 ,155 ,0 ,0 ,151 ,195 ,0 ,0 ,0 ,85 ,39 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,67 ,0 ,0 ,67 ,0 ,0 ,155 ,0 ,181 ,0 ,31 ,135 ,91 ,0 ,45 ,0 ,35 ,0 ,0 ,0 ,145 ,0 ,0 ,0 ,89 ,0 ,17 ,0 ,0 ,71 ,0 ,0 ,0 ,0 ,0 ,155 ,0 ,0 ,23 ,21 ,155 ,0 ,93 ,165 ,147 ,0 ,157 ,0 ,97 ,0 ,97 ,69 ,187 ,0 ,0 ,0 ,0 ,0 ,51 ,25 ,103 ,7 ,0 ,91 ,0 ,97 ,0 ,0 ,21 ,63 ,0 ,45 ,157 ,99 ,167 ,197 ,0 ,0 ,0 ,0 ,0 ,199 ,0 ,0 ,0 ,0 ,17 ,0 ,0 ,77 ,61 ,0 ,67 ,0 ,0 ,0 ,21 ,0 ,0 ,0 ,1 ,119 ,187 ,0}))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_5), true);
            return;
        }

        WriteProgress(typeof(U1_5), false);
        throw new WrongAnswerExeption($"Ikke korrekt svar");
    }

    #endregion
    
    #region 2
    
    public static void Udfordring2_1(Transform transform)
    {
        if (transform.position == new Vector3(10, 10, 10))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U2_1), true);
            return;
        }

        WriteProgress(typeof(U2_1), false);
        throw new WrongAnswerExeption($"positionen {transform.position} er ikke korrekt");
    }
    
    public static void Udfordring2_2(Transform transform)
    {
        if (transform.position == new Vector3(5, 5, 5) && transform.eulerAngles == new Vector3(180, 45, 23) && transform.localScale == new Vector3(2f, 1.2f, 0.02f))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U2_2), true);
            return;
        }

        WriteProgress(typeof(U2_2), false);
        throw new WrongAnswerExeption($"Svaret er ikke korrekt");
    }
    
    public static void Udfordring2_3(Transform transform)
    {
        if (transform.position.x == 28)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U2_3), true);
            return;
        }

        WriteProgress(typeof(U2_3), false);
        throw new WrongAnswerExeption($"positionen {transform.position} er ikke korrekt");
    }
    
    public static void Udfordring2_4(Transform transform)
    {
        if (transform.position == new Vector3(6.963642f, -7.071069f, 1.227878f))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U2_4), true);
            return;
        }

        WriteProgress(typeof(U2_4), false);
        throw new WrongAnswerExeption($"positionen {transform.position} er ikke korrekt");
    }

    

    #endregion
    
    #region 3
    
    public static void Udfordring3_1(Person person)
    {
        if (person.alder == 18)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U3_1), true);
            return;
        }

        WriteProgress(typeof(U3_1), false);
        throw new WrongAnswerExeption($"{person.alder} er ikke den korrekte alder");
    }
    
    public static void Udfordring3_2(Kriger kriger)
    {
        if (kriger.level == 47)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U3_2), true);
            return;
        }

        WriteProgress(typeof(U3_2), false);
        throw new WrongAnswerExeption($"Krigeren med level {kriger.level} er ikke korrekt");
    }
    
    public static void Udfordring3_3(AdvanceretKriger kriger)
    {
        Debug.Log(kriger.liv + " " + kriger.skade + " " + kriger.blokering);
        if (kriger.liv == 1 && kriger.skade == 2 && kriger.blokering == 1)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U3_3), true);
            return;
        }

        WriteProgress(typeof(U3_3), false);
        throw new WrongAnswerExeption($"Dette er ikke den korrekte kriger");
    }
    
    public static void Udfordring3_4(Hest[] heste)
    {
        if (heste.Length == 5 &&
            Mathf.Round(heste[0].LøbeTid(100)) == 3 &&
            Mathf.Round(heste[1].LøbeTid(200)) == 7 &&
            Mathf.Round(heste[2].LøbeTid(500)) == 17 &&
            Mathf.Round(heste[3].LøbeTid(1000)) == 34 &&
            Mathf.Round(heste[4].LøbeTid(50000)) == 3571)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U3_4), true);
            return;
        }

        WriteProgress(typeof(U3_4), false);
        throw new WrongAnswerExeption($"Det var ikke de rigtige heste, der vandt");
    }

    

    #endregion

    
    public static void DebugArray(int[] answer)
    {
        string a = "{";
        
        for (int i = 0; i < answer.Length; i++)
        {

            a += answer[i].ToString();

            if (i != answer.Length - 1)
                a += " ,";
        }

        a += "}";
        Debug.Log(a);
    }
    
    // public static void DebugClass(Hest[] answer)
    // {
    //     string a = "{";
    //     
    //     for (int i = 0; i < answer.Length; i++)
    //     {
    //         a += "new Hest(";
    //         a += answer[i].hastighed;
    //         a += ", ";
    //         a += answer[i].udholdenhed;
    //
    //
    //         a += ")";
    //         if (i != answer.Length - 1)
    //             a += " ,";
    //     }
    //
    //     a += "};";
    //     Debug.Log(a);
    // }
    
    private static void WriteProgress(Type type, bool solved)
    {
        string path = Application.persistentDataPath + "/Progress.txt";
        List<string> lines = new List<string>();
        if (File.Exists(path))
        {
            lines = File.ReadAllLines(path).ToList();
        }
        else
        {
            using (FileStream _ = File.Create(path)){}
        }

        lines.Remove(type.ToString());
        
        if (solved)
            lines.Add(type.ToString());

        File.WriteAllLines(path, lines);

    }
    
}

public class WrongAnswerExeption : Exception
{
    public WrongAnswerExeption(string s) : base(s) {}

    public override string StackTrace => "Prøv igen";
}