using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForEveryObstacle : MonoBehaviour
{
	public void Obstacles ()
    {
       SceneManager.LoadScene("Obstacles");
    }
}
