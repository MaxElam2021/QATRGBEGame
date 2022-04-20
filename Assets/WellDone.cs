using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WellDone : MonoBehaviour
{
    public AudioSource sfxPlayer;

	void Start()
	{
		sfxPlayer = GetComponent<AudioSource>();
	}

    public void MainMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

