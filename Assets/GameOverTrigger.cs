using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    PlayerController player;
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
           if (other.tag == "Player")
           {
            Debug.Log("in water");

            if (player.onPlatform == false) {
                    SceneManager.LoadScene("GameOver");
               }
           }
    }
}
