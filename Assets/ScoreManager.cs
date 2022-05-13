using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager instance;
	public Text text;
	int score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
		{
			instance = this;
		}
    }

	public void ChangeScore(int PhotoValue)
	{
		score += PhotoValue;
		text.text = "X" + score.ToString();
	}

}
