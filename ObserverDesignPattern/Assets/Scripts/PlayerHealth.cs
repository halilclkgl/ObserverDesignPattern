using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public delegate void PlayerDeath();
    public static event PlayerDeath OnPlayerDeath;

    public delegate void PlayerHealthChange(int health);
    public static event PlayerHealthChange OnPlayerHealthChange;

    public int maxHealth = 3;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            currentHealth = 0;

            if (OnPlayerDeath != null)
            {
                OnPlayerDeath();
            }
        }

        UpdateHealthText();
    }

    void UpdateHealthText()
    {
        if (OnPlayerHealthChange != null)
        {
            OnPlayerHealthChange(currentHealth);
        }
    }
}
