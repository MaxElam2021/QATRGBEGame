using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupdamage : MonoBehaviour
{
    PlayerController player;
    Health health;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        health = FindObjectOfType<Health>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
           if (other.tag == "Player")
           {
            health.TakeDamage(5);
             
           }
    }
}
