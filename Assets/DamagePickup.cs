using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamagePickup : MonoBehaviour
{
    PlayerController player;
    Health health;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        health = FindObjectOfType<Health>();
    }
    private void OnTriggerEnter2D(Collider other)
    {
        if (other.tag == "Player")
        {
            health.TakeDamage(10);
        }
    }
}
