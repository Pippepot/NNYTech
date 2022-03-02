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
    
    public static void Udfordring1_0()
    {
        Debug.Log("Svaret er korrekt!");
        WriteProgress(typeof(U1_0), true);
    }
    
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
    
    public static void Udfordring1_2_1(string[] answer)
    {
        if (answer == null)
        {
            WriteProgress(typeof(U1_2_1), false);
            throw new WrongAnswerExeption($"Indsæt familieMedlemmer i Dommer.Udfordring1_2_1");
        }
        
        if (answer.SequenceEqual(new string[] {"Bobby", "Karen", "Felix", "Lise"}))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_2_1), true);
            return;
        }

        WriteProgress(typeof(U1_2_1), false);
        throw new WrongAnswerExeption($"{StringArrayToString(answer)} er ikke det korrekte svar");
        
    }
    
    public static void Udfordring1_2_2(int answer)
    {
        if (answer == 35)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_2_2), true);
            return;
        }

        WriteProgress(typeof(U1_2_2), false);
        throw new WrongAnswerExeption($"{answer} er ikke det korrekte svar");
        
    }
    
    public static void Udfordring1_2_3(int answer)
    {
        if (answer == 341666)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_2_3), true);
            return;
        }

        WriteProgress(typeof(U1_2_3), false);
        throw new WrongAnswerExeption($"{answer} er ikke det korrekte svar");
    }
    
    public static void Udfordring1_3(int[] answer)
    {
        if (answer == null)
        {
            WriteProgress(typeof(U1_3), false);
            throw new WrongAnswerExeption($"Indsæt dit svar i Dommer.Udfordring1_3");
        }
        
        if (answer.SequenceEqual(new int[] {79, 47, 80, 913, 1543, 296, 1183, 340066}))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_3), true);
            return;
        }

        WriteProgress(typeof(U1_3), false);
        throw new WrongAnswerExeption($"{IntArrayToString(answer)} er ikke det korrekte svar");
    }
    
    public static void Udfordring1_4(int[] answer)
    {
        if (answer == null)
        {
            WriteProgress(typeof(U1_4), false);
            throw new WrongAnswerExeption($"Indsæt dit svar i Dommer.Udfordring1_4");
        }
        
        if (answer.SequenceEqual(new int[] {0 ,0 ,123 ,167 ,0 ,0 ,0 ,137 ,0 ,170 ,102 ,110 ,0 ,0 ,133 ,183 ,0 ,0 ,0 ,0 ,0 ,0 ,103 ,0 ,0 ,0 ,0 ,109 ,0 ,174 ,0 ,0 ,112 ,173 ,0 ,146 ,0 ,133 ,0 ,175 ,0 ,186 ,0 ,0 ,0 ,0 ,133 ,118 ,0 ,185 ,160 ,112 ,0 ,0 ,0 ,0 ,115 ,0 ,0 ,0 ,175 ,175 ,188 ,0 ,0 ,113 ,0 ,169 ,180 ,124 ,193 ,0 ,173 ,102 ,0 ,148 ,0 ,146 ,191 ,0 ,125 ,0 ,118 ,102 ,0 ,0 ,111 ,0 ,0 ,0 ,0 ,192 ,0 ,115 ,0 ,0 ,0 ,172 ,145 ,0 ,125 ,0 ,0 ,131 ,0 ,138 ,0 ,166 ,0 ,119 ,178 ,154 ,0 ,0 ,0 ,0 ,0 ,146 ,176 ,123 ,0 ,160 ,171 ,0 ,0 ,145 ,0 ,0 ,102 ,140 ,187 ,143 ,177 ,0 ,155 ,0 ,0 ,151 ,195 ,0 ,0 ,144 ,0 ,0 ,158 ,102 ,158 ,0 ,192 ,0 ,126 ,150 ,0 ,104 ,190 ,0 ,0 ,112 ,155 ,0 ,181 ,170 ,0 ,135 ,0 ,0 ,0 ,0 ,0 ,0 ,128 ,0 ,145 ,174 ,104 ,126 ,0 ,102 ,0 ,0 ,0 ,0 ,0 ,182 ,148 ,0 ,128 ,155 ,0 ,0 ,0 ,0 ,155 ,172 ,0 ,165 ,147 ,0 ,157 ,0 ,0 ,0 ,0 ,0 ,187 ,0 ,0 ,0 ,180 ,0 ,0 ,0 ,103 ,0 ,0 ,0 ,0 ,0 ,124 ,0 ,0 ,0 ,0 ,0 ,157 ,0 ,167 ,197 ,0 ,106 ,150 ,0 ,0 ,199 ,110 ,0 ,0 ,166 ,0 ,0 ,176 ,0 ,0 ,128 ,0 ,182 ,148 ,0 ,0 ,178 ,190 ,0 ,0 ,119 ,187 ,0}))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_4), true);
            return;
        }

        WriteProgress(typeof(U1_4), false);
        throw new WrongAnswerExeption($"{IntArrayToString(answer)} er ikke det korrekte svar");
    }
    
    public static void Udfordring1_5(int[] answer)
    {
        if (answer == null)
        {
            WriteProgress(typeof(U1_5), false);
            throw new WrongAnswerExeption($"Indsæt dit svar i Dommer.Udfordring1_5");
        }
        
        if (answer.SequenceEqual(new int[] {45, 123, 63, 33, 82, 102, 19, 133, 3, 11, 29, 103, 18, 43, 55, 50, 112, 47, 87, 14, 68, 42, 50, 133, 75, 160, 7, 51, 115, 99, 175, 188, 24, 45, 180, 193, 173, 62, 48, 191, 125, 118, 67, 111, 11, 77, 43, 99, 64, 145, 125, 38, 35, 74, 94, 178, 65, 35, 70, 176, 64, 171, 30, 31, 102, 187, 177, 155, 46, 195, 82, 85, 158, 158, 192, 126, 67, 190, 14, 155, 181, 31, 91, 45, 35, 128, 145, 104, 89, 17, 74, 86, 148, 128, 46, 23, 155, 93, 147, 157, 97, 97, 187, 74, 180, 51, 103, 40, 14, 124, 21, 74, 157, 167, 46, 150, 48, 110, 42, 17, 176, 61, 67, 148, 21, 190, 1, 187}))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U1_5), true);
            return;
        }

        WriteProgress(typeof(U1_5), false);
        throw new WrongAnswerExeption($"{IntArrayToString(answer)} er ikke det korrekte svar");
    }

    #endregion
    
    #region 2
    
    public static void Udfordring2_0(Transform transform)
    {
        if (transform.localScale == new Vector3(1, 1, 1))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U2_0), true);
            return;
        }

        WriteProgress(typeof(U2_0), false);
        throw new WrongAnswerExeption($"Størrelsen {transform.localScale} er ikke korrekt");
    }
    
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
        if (transform.position != new Vector3(5, 5, 5))
        {
            WriteProgress(typeof(U2_2), false);
            throw new WrongAnswerExeption($"{transform.position} er ikke den rigtige position. Positionen skal være (5, 5, 5)");
        }

        if (transform.eulerAngles != new Vector3(90,0,0))
        {
            WriteProgress(typeof(U2_2), false);
            throw new WrongAnswerExeption($"{transform.eulerAngles} er ikke den rigtige rotation. Rotationen skal være (160, 45, 23)");
        }

        if (transform.localScale != new Vector3(2f, 1.2f, 0.02f))
        {
            WriteProgress(typeof(U2_2), false);
            throw new WrongAnswerExeption($"{transform.localScale} er ikke den rigtige størrelse. Størrelsen skal være (2f, 1.2f, 0.02f");
        }

        Debug.Log("Svaret er korrekt!");
        WriteProgress(typeof(U2_2), true);
        return;
    }
    
    public static void Udfordring2_3(Transform transform)
    {
        if (transform.position.x == -1408)
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

    public static void Udfordring3_0()
    {
        GameObject obj = GameObject.Find("super objekt1");
        if (obj == null)
        {
            WriteProgress(typeof(U3_0), false);
            throw new WrongAnswerExeption($"Der findes ikke et objekt med navn 'super objekt1'");
        }
        
        if (obj.transform.position == new Vector3(3, 4, 5))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U3_0), true);
            return;
        }

        WriteProgress(typeof(U3_0), false);
        throw new WrongAnswerExeption($"Positionen {obj.transform.position} på objekt {obj.name} er ikke korrekt");
    }
    
    public static void Udfordring3_1()
    {
        GameObject obj = GameObject.Find("Turret(Clone)");
        if (obj == null)
        {
            WriteProgress(typeof(U3_1), false);
            throw new WrongAnswerExeption($"Der findes ikke et objekt med navn 'Turret(Clone)'");
        }
        
        if (Mathf.Approximately(obj.transform.eulerAngles.y, 30))
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U3_1), true);
            return;
        }

        WriteProgress(typeof(U3_1), false);
        throw new WrongAnswerExeption($"Rotationen {obj.transform.eulerAngles} på objekt {obj.name} er ikke korrekt");
    }

    public static void Udfordring3_2(MonoBehaviour behaviour)
    {
        behaviour.StartCoroutine(WaitForUdfordring3_2());
    }

    private static IEnumerator WaitForUdfordring3_2()
    {
        yield return null;
        
        GameObject obj = GameObject.Find("Projectile(Clone)");
        
        if (obj == null)
        {
            WriteProgress(typeof(U3_2), false);
            throw new WrongAnswerExeption($"Der findes ikke et objekt med navn 'Projectile(Clone)'");
        }
        
        Rigidbody body = obj.GetComponent<Rigidbody>();
        if (body == null)
        {
            WriteProgress(typeof(U3_2), false);
            throw new WrongAnswerExeption($"Der findes ikke noget Rigidbody component på {obj.name}");
        }
        
        if (body.velocity.y > 0)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U3_2), true);
            yield break;
        }

        WriteProgress(typeof(U3_2), false);
        throw new WrongAnswerExeption($"Velocity i y-aksen {body.velocity.y} på objekt {obj.name} er ikke opadgående");
    }
    
    public static void Udfordring3_3(MonoBehaviour behaviour)
    {
        
        
        behaviour.StartCoroutine(WaitForUdfordring3_3());
    }
    
    private static IEnumerator WaitForUdfordring3_3()
    {
        yield return null;
        
        GameObject obj = GameObject.Find("Projectile(Clone)");
        
        if (obj == null)
        {
            WriteProgress(typeof(U3_3), false);
            throw new WrongAnswerExeption($"Der findes ikke et objekt med navn 'Projectile(Clone)'");
        }
        
        Rigidbody body = obj.GetComponent<Rigidbody>();
        if (body == null)
        {
            WriteProgress(typeof(U3_3), false);
            throw new WrongAnswerExeption($"Der findes ikke noget Rigidbody component på {obj.name}");
        }
        
        if (Vector3.Dot(body.velocity.normalized, new Vector3(-7.0f, 0.7f, -7.0f).normalized) > 0.9999f)
        {
            Debug.Log("Svaret er korrekt!");
            WriteProgress(typeof(U3_3), true);
            yield break;
        }

        WriteProgress(typeof(U3_3), false);
        throw new WrongAnswerExeption($"Velocity {body.velocity} på objekt {obj.name} har ikke den korrekte retning");
    }
    
    #endregion

    
    #region 4


    #endregion

    
    public static string StringArrayToString(string[] array)
    {
        string a = "{";
        
        for (int i = 0; i < array.Length; i++)
        {

            a += array[i];

            if (i != array.Length - 1)
                a += ", ";
        }

        a += "}";
        return a;
    }
    
    public static string IntArrayToString(int[] array)
    {
        string a = "{";
        
        for (int i = 0; i < array.Length; i++)
        {

            a += array[i].ToString();

            if (i != array.Length - 1)
                a += ", ";
        }

        a += "}";
        return a;
    }
    
    // public static void DebugDict(Dictionary<Spiller, int> answer)
    // {
    //     string a = "{";
    //
    //     foreach (KeyValuePair<Spiller, int> fore in answer)
    //     {
    //         a += $"new KeyValuePair<Spiller, int>({fore.Key}, {fore.Value})";
    //         a += " ,";
    //
    //     }
    //
    //     a += "}";
    //     Debug.Log(a);
    // }
    
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