using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public AudioSource sfxPlayer;

	void Start()
	{
		sfxPlayer = GetComponent<AudioSource>();
	}

    public void Level1 ()
    {
        SceneManager.LoadScene("Cutscene1");
    }

	public void Level2 ()
    {
       SceneManager.LoadScene("Cutscene2");
    }

	public void MainMenu ()
    {
       SceneManager.LoadScene("MainMenu");
    }
}

