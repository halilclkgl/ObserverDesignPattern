using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageButton : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damageAmount = 1;

    public void TakeDamage()
    {
        playerHealth.TakeDamage(damageAmount);
    }

}
