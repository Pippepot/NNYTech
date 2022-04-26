using System;
using UnityEngine;

public class AwesomeAttacks : MonoBehaviour
{
    public bool canAttack = true;

    void Update()
    {
        if (canAttack)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Input.GetKey(KeyCode.LeftControl))
                {
                    if (Input.GetButtonDown("NormalAttack"))
                    {
                        Debug.Log("Normal Strong sneak attack");
                    }
                    else if (Input.GetButtonDown("RangedAttack"))
                    {
                        Debug.Log("Ranged Strong sneak attack");
                    }
                }
                else
                {
                    if (Input.GetButtonDown("NormalAttack"))
                    {
                        Debug.Log("Normal sneak attack");
                    }
                    else if (Input.GetButtonDown("RangedAttack"))
                    {
                        Debug.Log("Ranged sneak attack");
                    }
                }
            }
            else if (Input.GetKey(KeyCode.LeftControl))
            {
                if (Input.GetButtonDown("NormalAttack"))
                {
                    Debug.Log("Normal strong attack");
                }
                else if (Input.GetButtonDown("RangedAttack"))
                {
                    Debug.Log("Ranged strong attack");
                }
            }
            else if (Input.GetButtonDown("NormalAttack"))
            {
                Debug.Log("Normal attack");
            }
            else if (Input.GetButtonDown("RangedAttack"))
            {
                Debug.Log("Ranged attack");
            }
        }
    }
}