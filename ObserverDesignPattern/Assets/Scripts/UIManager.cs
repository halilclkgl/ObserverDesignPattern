using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    public TMP_Text healthText;
    public TMP_Text gameOverText;
    public PlayerHealth playerHealth;

    void Start()
    {
        PlayerHealth.OnPlayerHealthChange += UpdateHealthText;
        PlayerHealth.OnPlayerDeath += ShowGameOver;
    }

    void ShowGameOver()
    {
        gameOverText.text = "Game Over!";
    }

    void UpdateHealthText(int health)
    {
        healthText.text = "Health: " + health;
    }

    void OnDestroy()
    {
        PlayerHealth.OnPlayerHealthChange -= UpdateHealthText;
        PlayerHealth.OnPlayerDeath -= ShowGameOver;
    }
}
