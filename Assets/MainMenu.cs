using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource sfxPlayer;

	void Start()
	{
		sfxPlayer = GetComponent<AudioSource>();
	}

    public void PlayGame ()
    {
        SceneManager.LoadScene("Cutscene1");
    }

	public void Credits ()
    {
       SceneManager.LoadScene("Credits");
    }

	public void Introductions ()
    {
       SceneManager.LoadScene("Introductions");
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
