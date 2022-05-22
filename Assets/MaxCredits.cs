using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaxCredits : MonoBehaviour
{
    public AudioSource sfxPlayer;

    void Start()
    {
        sfxPlayer = GetComponent<AudioSource>();
    }

    public void JaydenCredits()
    {
        SceneManager.LoadScene("JaydenCredits");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

	public void Thanks()
    {
        SceneManager.LoadScene("SpecialThanks");
    }
}