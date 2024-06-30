using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
     // Amount of damage the hazard deals
    public int damage = 10;

    // Method called when another collider enters the trigger collider attached to the object
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            // Reduce the player's health by the damage amount
            playerHealth.TakeDamage(damage);
        }
    }
}
