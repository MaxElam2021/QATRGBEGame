using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introductions : MonoBehaviour
{
	public void MainMenu ()
    {
       SceneManager.LoadScene("MainMenu");
    }

	public void GameAbout ()
    {
       SceneManager.LoadScene("Introductions");
    }

	public void PlayerControls ()
    {
       SceneManager.LoadScene("Controls");
    }

	public void Obstacles ()
    {
       SceneManager.LoadScene("Obstacles");
    }

	public void Objective ()
    {
       SceneManager.LoadScene("Objective");
    }

	public void UI ()
    {
       SceneManager.LoadScene("UI");
    }
}
