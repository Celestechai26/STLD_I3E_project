using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    // Player's initial health
    public int maxHealth = 100;
    private int currentHealth;

    // Reference to the UI element that displays the player's health
    public Text healthText;

    private void Start()
    {
        // Set the player's current health to the maximum health at the start
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    // Method to reduce the player's health
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Clamp the health value to ensure it doesn't go below zero
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // Update the health UI
        UpdateHealthUI();

        // Check if the player's health has reached zero
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Method to update the health UI text
    private void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth.ToString();
        }
    }

    // Method called when the player's health reaches zero
    private void Die()
    {
        // Here you can add logic for what happens when the player dies
        Debug.Log("Player has died!");
        // For example, you might want to reload the scene or show a game over screen
    }
}
