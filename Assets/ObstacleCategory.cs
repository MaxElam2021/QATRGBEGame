using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCategory : MonoBehaviour
{
	public void PhotoObstacle ()
    {
       SceneManager.LoadScene("PhotoObstacle");
    }

	public void EnemyObstacle ()
    {
       SceneManager.LoadScene("EnemyObstacle");
    }

	public void TrashObjectObstacle ()
    {
       SceneManager.LoadScene("TrashObstacle");
    }

	public void SeaObstacle ()
    {
       SceneManager.LoadScene("SeaObstacle");
    }

		public void PlatformObstacle ()
    {
       SceneManager.LoadScene("PlatformObstacle");
    }
}
