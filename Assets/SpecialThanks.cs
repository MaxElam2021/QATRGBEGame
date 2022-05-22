using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpecialThanks : MonoBehaviour
{
    public AudioSource sfxPlayer;

    void Start()
    {
        sfxPlayer = GetComponent<AudioSource>();
    }

	public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void MaxCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void JaydenCredits()
    {
        SceneManager.LoadScene("JaydenCredits");
    }
}