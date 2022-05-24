using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 1000;

    private void Update()
    {
        if(healthAmount <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void TakeDamage(float Damage)
    {
        Debug.Log("Damage");
        healthAmount -= Damage;
        Debug.Log(healthBar);

        healthBar.fillAmount = healthAmount / 1000;
    }

    public void Healing(float healPoints)
    {
        Debug.Log(healPoints);
        healthAmount += healPoints;
        healthAmount = Mathf.Clamp(healthAmount, 0, 1000);

        healthBar.fillAmount = healthAmount / 1000;
    }
}
